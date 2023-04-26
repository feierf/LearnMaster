using CSharpMath.Atom;
using CSharpMath.Rendering.FrontEnd;
using CSharpMath.SkiaSharp;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnMaster
{
    public partial class FormMain : Form
    {
        List<Dataset> datasetList = null;

        List<Dataset> notSelectedDataSet = null;
        bool testRunning = false;
        Dataset currentData = null;
        int questionsLeft = 0;
        int index;

        public FormMain()
        {
            InitializeComponent();
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEquation.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void loadDatasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"c:\";
                openFileDialog.Filter = @"Dataset (*.ds)|*.ds|Binary files (*.bin)|*.bin|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    using (Stream s = openFileDialog.OpenFile())
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        datasetList = bf.Deserialize(s) as List<Dataset>;
                    }
                }
            }
        }

        private void RenderEquation(string equation)
        {
            var painter = new MathPainter { LaTeX = equation };
            try
            {
                var bmp = new Bitmap(painter.DrawAsStream());
                pictureBoxEquation.Visible = true;
                pictureBoxEquation.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "; " + ex.StackTrace);
            }
        }

        private void editDatasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datasetList == null)
            {
                MessageBox.Show("No dataset selected! Create or load a datset before loading it!");
                return;
            }

            FormEditDataset fed = new FormEditDataset(datasetList);

            fed.Show();
            fed.DatasetUpdated += Fed_DatasetUpdated;
        }

        private void Fed_DatasetUpdated(object sender, FormEditDataset.DatasetUpdatedEventArgs e)
        {
            this.datasetList = e.list;
        }

        private void createNewDatasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditDataset fed = new FormEditDataset(datasetList);

            fed.Show();
            fed.DatasetUpdated += Fed_DatasetUpdated;
        }

        private void startTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testRunning = true;
            tableLayoutPanelTest.Visible = true;
            notSelectedDataSet = new List<Dataset>(datasetList);

            Dataset ds = SelectRandomDataset(notSelectedDataSet);
            currentData = ds;
            textBoxAskedQuestions.Text = "0";
            textBoxMistakes.Text = "0";
            textBoxQuestionsLeft.Text = datasetList.Count.ToString();
            textBoxCorrectAnswers.Text = "0";
            questionsLeft = datasetList.Count;
            SetTextBoxes(ds);
        }

        private void SetTextBoxes(Dataset ds)
        {
            if (ds._isEquation && ds._equation.Length > 0)
            {
                RenderEquation(ds._equation);
                pictureBoxEquation.Visible = true;
            }
            if (ds._isImage)
            {
                pictureBoxImage.Image = ds._image;
                pictureBoxImage.Visible = true;
            }
            labelQuestion.Text = ds._question;
        }

        private Dataset SelectRandomDataset(List<Dataset> datasets)
        {
            Random random = new Random();
            int index = random.Next(datasets.Count);
            this.index = index;

            Dataset ds = datasets[index];
            ds._asked = true;
            datasets.Remove(ds);
            return ds;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            buttonCheck.Enabled = false;
            buttonNext.Visible = true;
            Dataset ds = new Dataset("", textBoxDescription.Text, textBoxAnswer.Text);
            if (currentData.AnsweredCorrect(ds))
            {
                textBoxResult.Text = "Correct!";
                textBoxCorrectAnswers.Text = (int.Parse(textBoxCorrectAnswers.Text) + 1).ToString();
            }
            else
            {
                textBoxResult.Text = "Incorrect! Correct answer now visible!";
                textBoxAnswer.Text = currentData._solution;
                textBoxMistakes.Text = (int.Parse(textBoxMistakes.Text) + 1).ToString();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonCheck.Enabled = true;
            buttonNext.Visible = false;
            pictureBoxImage.Visible = false;
            pictureBoxImage.Visible = false;
            if (--questionsLeft > 0)
            {
                currentData = SelectRandomDataset(notSelectedDataSet);

                SetTextBoxes(currentData);
            }
            else
            {
                MessageBox.Show("Test Completed!");
                foreach (Dataset ds in datasetList)
                {
                    ds.ResetExamData();
                }
            }
            textBoxAskedQuestions.Text = (int.Parse(textBoxAskedQuestions.Text) + 1).ToString();
            textBoxQuestionsLeft.Text = questionsLeft.ToString();
            textBoxAnswer.Text = "";
            textBoxDescription.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
