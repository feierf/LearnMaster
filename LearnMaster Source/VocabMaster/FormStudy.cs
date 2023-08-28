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
            textBoxQuestion.Text = dataSet._question;
            textBoxResult.Text = dataSet._solution;
            textBoxDescription.Text = dataSet._description;
            labelQuestionNumber.Text = $"{index + 1}/{_dataSetList.Count}";
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
