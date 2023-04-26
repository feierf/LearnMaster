namespace LearnMaster
{
    partial class FormEditDataset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditDataset));
            this.listBoxDataset = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonSaveNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveModified = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxImage = new System.Windows.Forms.CheckBox();
            this.checkBoxEquation = new System.Windows.Forms.CheckBox();
            this.textBoxEquation = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDataset
            // 
            this.listBoxDataset.FormattingEnabled = true;
            this.listBoxDataset.Location = new System.Drawing.Point(12, 25);
            this.listBoxDataset.Name = "listBoxDataset";
            this.listBoxDataset.Size = new System.Drawing.Size(151, 407);
            this.listBoxDataset.TabIndex = 0;
            this.listBoxDataset.SelectedIndexChanged += new System.EventHandler(this.listBoxDataset_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDatasetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDatasetToolStripMenuItem
            // 
            this.saveDatasetToolStripMenuItem.Name = "saveDatasetToolStripMenuItem";
            this.saveDatasetToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveDatasetToolStripMenuItem.Text = "Save Dataset";
            this.saveDatasetToolStripMenuItem.Click += new System.EventHandler(this.saveDatasetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45098F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.54902F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxQuestion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAnswer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDescription, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSaveNew, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(169, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.63374F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.63375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.63375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.63375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.46502F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 407);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestion.Location = new System.Drawing.Point(172, 95);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(444, 86);
            this.textBoxQuestion.TabIndex = 3;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAnswer.Location = new System.Drawing.Point(172, 187);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(444, 86);
            this.textBoxAnswer.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(172, 279);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(444, 86);
            this.textBoxDescription.TabIndex = 5;
            // 
            // buttonSaveNew
            // 
            this.buttonSaveNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveNew.Location = new System.Drawing.Point(3, 371);
            this.buttonSaveNew.Name = "buttonSaveNew";
            this.buttonSaveNew.Size = new System.Drawing.Size(163, 33);
            this.buttonSaveNew.TabIndex = 6;
            this.buttonSaveNew.Text = "Save as new";
            this.buttonSaveNew.UseVisualStyleBackColor = true;
            this.buttonSaveNew.Click += new System.EventHandler(this.buttonSaveNew_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSaveModified, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDelete, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(172, 371);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 33);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // buttonSaveModified
            // 
            this.buttonSaveModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveModified.Location = new System.Drawing.Point(3, 3);
            this.buttonSaveModified.Name = "buttonSaveModified";
            this.buttonSaveModified.Size = new System.Drawing.Size(216, 27);
            this.buttonSaveModified.TabIndex = 8;
            this.buttonSaveModified.Text = "Save as Modified";
            this.buttonSaveModified.UseVisualStyleBackColor = true;
            this.buttonSaveModified.Click += new System.EventHandler(this.buttonSaveModified_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(225, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(216, 27);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Question-Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxEquation);
            this.panel1.Controls.Add(this.checkBoxImage);
            this.panel1.Controls.Add(this.checkBoxEquation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(172, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 86);
            this.panel1.TabIndex = 9;
            // 
            // checkBoxImage
            // 
            this.checkBoxImage.AutoSize = true;
            this.checkBoxImage.Location = new System.Drawing.Point(334, 32);
            this.checkBoxImage.Name = "checkBoxImage";
            this.checkBoxImage.Size = new System.Drawing.Size(55, 17);
            this.checkBoxImage.TabIndex = 1;
            this.checkBoxImage.Text = "Image";
            this.checkBoxImage.UseVisualStyleBackColor = true;
            this.checkBoxImage.CheckedChanged += new System.EventHandler(this.checkBoxImage_CheckedChanged);
            // 
            // checkBoxEquation
            // 
            this.checkBoxEquation.AutoSize = true;
            this.checkBoxEquation.Location = new System.Drawing.Point(24, 17);
            this.checkBoxEquation.Name = "checkBoxEquation";
            this.checkBoxEquation.Size = new System.Drawing.Size(68, 17);
            this.checkBoxEquation.TabIndex = 0;
            this.checkBoxEquation.Text = "Equation";
            this.checkBoxEquation.UseVisualStyleBackColor = true;
            this.checkBoxEquation.CheckedChanged += new System.EventHandler(this.checkBoxEquation_CheckedChanged);
            // 
            // textBoxEquation
            // 
            this.textBoxEquation.Location = new System.Drawing.Point(24, 40);
            this.textBoxEquation.Name = "textBoxEquation";
            this.textBoxEquation.Size = new System.Drawing.Size(214, 20);
            this.textBoxEquation.TabIndex = 2;
            // 
            // FormEditDataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBoxDataset);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEditDataset";
            this.Text = "Edit Dataset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditDataset_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDataset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSaveModified;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxImage;
        private System.Windows.Forms.CheckBox checkBoxEquation;
        private System.Windows.Forms.TextBox textBoxEquation;
    }
}