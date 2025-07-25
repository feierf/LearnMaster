using CSharpMath.Atom;
using CSharpMath.Rendering.FrontEnd;
using CSharpMath.SkiaSharp;
using SkiaSharp;
using LearnMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabMaster
{
    public partial class FormStudy : Form
    {
        private List<Dataset> _dataSetList;
        private int index = 0;

        public FormStudy(List<Dataset> dataSetList)
        {
            InitializeComponent();

            _dataSetList = dataSetList;
            index = 0;
            textBoxResult.Visible = false;
            textBoxDescription.Visible = false;
            DisplayDataset(_dataSetList[index]);
        }

        private void DisplayDataset(Dataset dataSet) 
        {
            textBoxResult.Visible = false;
            textBoxDescription.Visible = false;
            pictureBoxEquation.Visible = false;
            pictureBoxImage.Visible = false;
            textBoxQuestion.Text = dataSet._question;
            textBoxResult.Text = dataSet._solution;
            textBoxDescription.Text = dataSet._description;
            labelQuestionNumber.Text = $"{index + 1}/{_dataSetList.Count}";

            if (!dataSet._isEquation && !dataSet._isImage)
            {
                tableLayoutPanelImageEquation.Visible = false;
                tableLayoutPanel3.RowStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel3.RowStyles[1].Height = 0;
                tableLayoutPanel3.RowStyles[2].SizeType = SizeType.Percent;
                tableLayoutPanel3.RowStyles[2].Height = 30;
                tableLayoutPanel3.RowStyles[3].SizeType = SizeType.Percent;
                tableLayoutPanel3.RowStyles[3].Height = 70;
            }
            else
            {
                tableLayoutPanel3.RowStyles[2].SizeType = SizeType.Absolute;
                tableLayoutPanel3.RowStyles[2].Height = 60;
                tableLayoutPanel3.RowStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel3.RowStyles[1].Height = 100;
                tableLayoutPanel3.RowStyles[3].SizeType = SizeType.AutoSize;
                tableLayoutPanelImageEquation.Visible = true;
                if (dataSet._isEquation && dataSet._equation.Length > 0)
                {
                    RenderEquation(dataSet._equation);
                    pictureBoxEquation.Visible = true;
                }
                if (dataSet._isImage)
                {
                    pictureBoxImage.Image = dataSet._image;
                    pictureBoxImage.Visible = true;
                }
            }

            if (dataSet._description.Length == 0)
            {
                tableLayoutPanelDescriptionResult.ColumnStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanelDescriptionResult.ColumnStyles[1].Width = 0;
            }
            else
            {
                tableLayoutPanelDescriptionResult.ColumnStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanelDescriptionResult.ColumnStyles[1].Width = 50;
            }

            if (dataSet._solution.Length == 0)
            {
                tableLayoutPanelDescriptionResult.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanelDescriptionResult.ColumnStyles[0].Width = 0;
            }
            else
            {
                tableLayoutPanelDescriptionResult.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanelDescriptionResult.ColumnStyles[0].Width = 50;
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

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index + 1 == _dataSetList.Count)
            {
                index = 0;
            }
            else
            {
                index++;
            }

            DisplayDataset(_dataSetList[index]);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (index - 1 < 0)
            {
                index = _dataSetList.Count - 1;
            }
            else
            {
                index--;
            }

            DisplayDataset(_dataSetList[index]);
        }

        private void buttonToggleResult_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Visible)
            {
                textBoxResult.Visible = false;
            }
            else
            {
                textBoxResult.Visible = true;
            }
        }

        private void buttonToggleDescription_Click(object sender, EventArgs e)
        {
            if (textBoxDescription.Visible)
            {
                textBoxDescription.Visible = false;
            }
            else
            {
                textBoxDescription.Visible = true;
            }
        }
    }
}
