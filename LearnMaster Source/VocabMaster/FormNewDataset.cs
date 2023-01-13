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
    public partial class FormNewDataset : Form
    {
        public Dataset newDataset { get; set; }

        public FormNewDataset()
        {
            InitializeComponent();
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            newDataset = new Dataset(textBoxQuestion.Text, textBoxDescription.Text, textBoxAnswer.Text);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
