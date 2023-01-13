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

namespace VocabMaster
{
    public partial class FormEditDataset : Form
    {
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
            Dataset ds = listBoxDataset.SelectedItem as Dataset;

            textBoxAnswer.Text = ds.solution;
            textBoxDescription.Text = ds.description;
            textBoxQuestion.Text = ds.question;
        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text.Length > 0 && textBoxAnswer.Text.Length > 0)
            {
                listBoxDataset.Items.Add(new Dataset(textBoxQuestion.Text, textBoxDescription.Text, textBoxAnswer.Text));
            }
        }

        private void buttonSaveModified_Click(object sender, EventArgs e)
        {
            Dataset ds = listBoxDataset.SelectedItem as Dataset;

            if (textBoxAnswer.Text.Length > 0 && textBoxAnswer.Text != ds.solution)
            {
                ds.solution = textBoxAnswer.Text;
            }
            if (textBoxQuestion.Text.Length > 0 && textBoxQuestion.Text != ds.question)
            {
                ds.question = textBoxQuestion.Text;
            }
            if (textBoxDescription.Text.Length > 0 && textBoxDescription.Text != ds.description)
            {
                ds.description = textBoxDescription.Text;
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
    }
}
