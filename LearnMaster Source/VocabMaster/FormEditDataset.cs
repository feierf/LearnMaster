using CSharpMath.Display.FrontEnd;
using CSharpMath.Rendering.BackEnd;
using CSharpMath.Rendering.FrontEnd;
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
    public partial class FormEditDataset : Form
    {
        private bool isImage;
        private bool isEquation;
        private Bitmap bmp;

        public FormEditDataset(List<Dataset> datasetList)
        {
            InitializeComponent();
            if (datasetList != null)
            {
                setListBoxItems(datasetList);
            }
        }

        private void setListBoxItems (List<Dataset> datasets)
        {
            foreach (var ds in datasets)
            {
                listBoxDataset.Items.Add(ds);
            }
        }

        public delegate void DatasetUpdatedDelegate(object sender, DatasetUpdatedEventArgs e);
        public event DatasetUpdatedDelegate DatasetUpdated = delegate { };

        private void listBoxDataset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDataset.SelectedIndex >= 0)
            {
                Dataset ds = listBoxDataset.SelectedItem as Dataset;

                textBoxAnswer.Text = ds._solution;
                textBoxDescription.Text = ds._description;
                textBoxQuestion.Text = ds._question;
            }
            else
            {
                textBoxAnswer.Text = "";
                textBoxDescription.Text = "";
                textBoxQuestion.Text = "";
                isImage = false;
                bmp = null;
                isEquation = false;
                checkBoxEquation.Checked = false;
                checkBoxImage.Checked = false;
            }
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text.Length > 0 && textBoxAnswer.Text.Length > 0)
            {
                listBoxDataset.Items.Add(new Dataset(textBoxQuestion.Text, textBoxDescription.Text, textBoxAnswer.Text, isEquation, isImage, bmp));
            }
        }

        private void buttonSaveModified_Click(object sender, EventArgs e)
        {
            Dataset ds = listBoxDataset.SelectedItem as Dataset;

            if (textBoxAnswer.Text.Length > 0 && textBoxAnswer.Text != ds._solution)
            {
                ds._solution = textBoxAnswer.Text;
            }
            if (textBoxQuestion.Text.Length > 0 && textBoxQuestion.Text != ds._question)
            {
                ds._question = textBoxQuestion.Text;
            }
            if (textBoxDescription.Text.Length > 0 && textBoxDescription.Text != ds._description)
            {
                ds._description = textBoxDescription.Text;
            }
            if (bmp != null && isImage)
            {
                ds._isImage = true;
                ds._image = bmp;
            }
            if (isEquation)
            {
                ds._isEquation = true;
            }
        }

        public class DatasetUpdatedEventArgs
        {
            public List<Dataset> list { get; }

            public DatasetUpdatedEventArgs(List<Dataset> list)
            {
                this.list = list;
            }
        }

        private void FormEditDataset_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatasetUpdated(this, new DatasetUpdatedEventArgs(GetDatasets()));
        }

        private List<Dataset> GetDatasets()
        {
            List<Dataset> datasets = new List<Dataset>();

            foreach (var item in listBoxDataset.Items)
            {
                datasets.Add(item as Dataset);
            }

            return datasets;
        }

        private void saveDatasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = @"Dataset (*.ds)|*.ds|Binary files (*.bin)|*.bin|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file's path
                    string filePath = saveFileDialog.FileName;
                    // Serialize the object and write it to the file
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, GetDatasets());
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxDataset.Items.Remove(listBoxDataset.SelectedItem);
            isImage = false;
            isEquation = false;
            bmp = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxEquation_CheckedChanged(object sender, EventArgs e)
        {
            isEquation = checkBoxEquation.Checked;
        }

        private void checkBoxImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxImage.Checked)
            {
                // Create an instance of OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Set the filter for the file types to be displayed
                openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.png, *.jpeg)|*.bmp;*.jpg;*.png;*.jpeg";

                // Show the dialog and get the result
                DialogResult result = openFileDialog.ShowDialog();

                // Check if the user selected a file and clicked OK
                if (result == DialogResult.OK)
                {
                    // Get the filename and path of the selected file
                    string filename = openFileDialog.FileName;

                    // Create an instance of Bitmap from the file
                    Bitmap bmp = new Bitmap(filename);
                    this.bmp = bmp;
                    this.isImage = true;
                }
                else
                {
                    checkBoxImage.Checked = false;
                    isImage = false;
                    bmp = null;
                }
            }
            else
            {
                this.isImage = false;
                this.bmp = null;
            }
        }
    }
}
