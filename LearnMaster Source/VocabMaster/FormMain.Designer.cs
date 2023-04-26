namespace LearnMaster
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelTest = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAskedQuestions = new System.Windows.Forms.TextBox();
            this.textBoxCorrectAnswers = new System.Windows.Forms.TextBox();
            this.textBoxMistakes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuestionsLeft = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxEquation = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanelTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDatasetToolStripMenuItem,
            this.createNewDatasetToolStripMenuItem,
            this.startTestToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDatasetToolStripMenuItem
            // 
            this.loadDatasetToolStripMenuItem.Name = "loadDatasetToolStripMenuItem";
            this.loadDatasetToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.loadDatasetToolStripMenuItem.Text = "Load Dataset";
            this.loadDatasetToolStripMenuItem.Click += new System.EventHandler(this.loadDatasetToolStripMenuItem_Click);
            // 
            // createNewDatasetToolStripMenuItem
            // 
            this.createNewDatasetToolStripMenuItem.Name = "createNewDatasetToolStripMenuItem";
            this.createNewDatasetToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.createNewDatasetToolStripMenuItem.Text = "Create new Dataset";
            this.createNewDatasetToolStripMenuItem.Click += new System.EventHandler(this.createNewDatasetToolStripMenuItem_Click);
            // 
            // startTestToolStripMenuItem
            // 
            this.startTestToolStripMenuItem.Name = "startTestToolStripMenuItem";
            this.startTestToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.startTestToolStripMenuItem.Text = "Start Test";
            this.startTestToolStripMenuItem.Click += new System.EventHandler(this.startTestToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDatasetToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editDatasetToolStripMenuItem
            // 
            this.editDatasetToolStripMenuItem.Name = "editDatasetToolStripMenuItem";
            this.editDatasetToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editDatasetToolStripMenuItem.Text = "Edit Dataset";
            this.editDatasetToolStripMenuItem.Click += new System.EventHandler(this.editDatasetToolStripMenuItem_Click);
            // 
            // tableLayoutPanelTest
            // 
            this.tableLayoutPanelTest.ColumnCount = 2;
            this.tableLayoutPanelTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.58088F));
            this.tableLayoutPanelTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.41912F));
            this.tableLayoutPanelTest.Controls.Add(this.textBoxResult, 0, 3);
            this.tableLayoutPanelTest.Controls.Add(this.labelDescription, 0, 2);
            this.tableLayoutPanelTest.Controls.Add(this.buttonCheck, 1, 3);
            this.tableLayoutPanelTest.Controls.Add(this.textBoxDescription, 1, 2);
            this.tableLayoutPanelTest.Controls.Add(this.labelQuestion, 0, 1);
            this.tableLayoutPanelTest.Controls.Add(this.textBoxAnswer, 1, 1);
            this.tableLayoutPanelTest.Controls.Add(this.buttonNext, 1, 4);
            this.tableLayoutPanelTest.Controls.Add(this.pictureBoxImage, 1, 0);
            this.tableLayoutPanelTest.Controls.Add(this.pictureBoxEquation, 0, 0);
            this.tableLayoutPanelTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTest.Location = new System.Drawing.Point(409, 3);
            this.tableLayoutPanelTest.Name = "tableLayoutPanelTest";
            this.tableLayoutPanelTest.RowCount = 5;
            this.tableLayoutPanelTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.32803F));
            this.tableLayoutPanelTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.49503F));
            this.tableLayoutPanelTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.69384F));
            this.tableLayoutPanelTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.619379F));
            this.tableLayoutPanelTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.619379F));
            this.tableLayoutPanelTest.Size = new System.Drawing.Size(544, 503);
            this.tableLayoutPanelTest.TabIndex = 1;
            this.tableLayoutPanelTest.Visible = false;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(3, 408);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(192, 20);
            this.textBoxResult.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 316);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description:";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheck.Location = new System.Drawing.Point(201, 408);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(340, 42);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(201, 319);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(340, 83);
            this.textBoxDescription.TabIndex = 4;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(3, 228);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(52, 13);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question:";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAnswer.Location = new System.Drawing.Point(201, 231);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(340, 82);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNext.Location = new System.Drawing.Point(201, 456);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(340, 44);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next Question";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(201, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(340, 222);
            this.pictureBoxImage.TabIndex = 7;
            this.pictureBoxImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAskedQuestions, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCorrectAnswers, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMistakes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxQuestionsLeft, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 503);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistics:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Questions Asked:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correct Answers:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mistakes:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAskedQuestions
            // 
            this.textBoxAskedQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAskedQuestions.Location = new System.Drawing.Point(203, 103);
            this.textBoxAskedQuestions.Name = "textBoxAskedQuestions";
            this.textBoxAskedQuestions.ReadOnly = true;
            this.textBoxAskedQuestions.Size = new System.Drawing.Size(194, 20);
            this.textBoxAskedQuestions.TabIndex = 4;
            // 
            // textBoxCorrectAnswers
            // 
            this.textBoxCorrectAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCorrectAnswers.Location = new System.Drawing.Point(203, 203);
            this.textBoxCorrectAnswers.Name = "textBoxCorrectAnswers";
            this.textBoxCorrectAnswers.ReadOnly = true;
            this.textBoxCorrectAnswers.Size = new System.Drawing.Size(194, 20);
            this.textBoxCorrectAnswers.TabIndex = 5;
            // 
            // textBoxMistakes
            // 
            this.textBoxMistakes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMistakes.Location = new System.Drawing.Point(203, 303);
            this.textBoxMistakes.Name = "textBoxMistakes";
            this.textBoxMistakes.ReadOnly = true;
            this.textBoxMistakes.Size = new System.Drawing.Size(194, 20);
            this.textBoxMistakes.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Questions Left:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxQuestionsLeft
            // 
            this.textBoxQuestionsLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestionsLeft.Location = new System.Drawing.Point(203, 403);
            this.textBoxQuestionsLeft.Name = "textBoxQuestionsLeft";
            this.textBoxQuestionsLeft.ReadOnly = true;
            this.textBoxQuestionsLeft.Size = new System.Drawing.Size(194, 20);
            this.textBoxQuestionsLeft.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.5F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanelTest, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(956, 509);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBoxEquation
            // 
            this.pictureBoxEquation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEquation.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxEquation.Name = "pictureBoxEquation";
            this.pictureBoxEquation.Size = new System.Drawing.Size(192, 222);
            this.pictureBoxEquation.TabIndex = 8;
            this.pictureBoxEquation.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 533);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "LearnMaster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanelTest.ResumeLayout(false);
            this.tableLayoutPanelTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTestToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTest;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAskedQuestions;
        private System.Windows.Forms.TextBox textBoxCorrectAnswers;
        private System.Windows.Forms.TextBox textBoxMistakes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuestionsLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxEquation;
    }
}

