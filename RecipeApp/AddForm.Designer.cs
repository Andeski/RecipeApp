namespace RecipeApp
{
    partial class AddForm
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
            label1 = new Label();
            NameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TypeBox = new TextBox();
            label4 = new Label();
            PortionsBox = new NumericUpDown();
            DifficultyBox = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            IngredientBox = new TextBox();
            InstructionsBox = new TextBox();
            label8 = new Label();
            AddBtn = new Button();
            CancelBtn = new Button();
            label9 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            groupBoxUploadImage = new GroupBox();
            textBoxFileName = new TextBox();
            buttonBrowse = new Button();
            openFileDialogUploadImage = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)PortionsBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DifficultyBox).BeginInit();
            panel1.SuspendLayout();
            groupBoxUploadImage.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 0;
            label1.Text = "Add your own recipe";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(151, 51);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(271, 23);
            NameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 49);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 78);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 4;
            label3.Text = "Type:";
            // 
            // TypeBox
            // 
            TypeBox.Location = new Point(151, 80);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(271, 23);
            TypeBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 108);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 5;
            label4.Text = "Portions:";
            // 
            // PortionsBox
            // 
            PortionsBox.Location = new Point(151, 108);
            PortionsBox.Name = "PortionsBox";
            PortionsBox.Size = new Size(45, 23);
            PortionsBox.TabIndex = 6;
            // 
            // DifficultyBox
            // 
            DifficultyBox.Location = new Point(151, 138);
            DifficultyBox.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            DifficultyBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DifficultyBox.Name = "DifficultyBox";
            DifficultyBox.Size = new Size(45, 23);
            DifficultyBox.TabIndex = 8;
            DifficultyBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 136);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 7;
            label5.Text = "Difficulty:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 140);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 9;
            label6.Text = "(1 easy - 3 difficult)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(23, 162);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 11;
            label7.Text = "Ingredients:";
            // 
            // IngredientBox
            // 
            IngredientBox.Location = new Point(151, 167);
            IngredientBox.Multiline = true;
            IngredientBox.Name = "IngredientBox";
            IngredientBox.Size = new Size(271, 154);
            IngredientBox.TabIndex = 12;
            // 
            // InstructionsBox
            // 
            InstructionsBox.Location = new Point(151, 327);
            InstructionsBox.Multiline = true;
            InstructionsBox.Name = "InstructionsBox";
            InstructionsBox.Size = new Size(271, 154);
            InstructionsBox.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 327);
            label8.Name = "label8";
            label8.Size = new Size(123, 25);
            label8.TabIndex = 13;
            label8.Text = "Instructions:";
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.Location = new Point(343, 576);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(79, 38);
            AddBtn.TabIndex = 15;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CancelBtn.Location = new Point(257, 576);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(79, 38);
            CancelBtn.TabIndex = 16;
            CancelBtn.Text = "Close";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(70, 510);
            label9.Name = "label9";
            label9.Size = new Size(72, 25);
            label9.TabIndex = 17;
            label9.Text = "Image:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 626);
            panel1.TabIndex = 18;
            // 
            // label11
            // 
            label11.BackColor = Color.DarkOliveGreen;
            label11.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(33, 352);
            label11.Name = "label11";
            label11.Size = new Size(112, 38);
            label11.TabIndex = 19;
            label11.Text = "Seperate lines with comma \",\"";
            // 
            // label10
            // 
            label10.BackColor = Color.DarkOliveGreen;
            label10.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(33, 187);
            label10.Name = "label10";
            label10.Size = new Size(112, 38);
            label10.TabIndex = 18;
            label10.Text = "Seperate lines with comma \",\"";
            // 
            // groupBoxUploadImage
            // 
            groupBoxUploadImage.Controls.Add(textBoxFileName);
            groupBoxUploadImage.Controls.Add(buttonBrowse);
            groupBoxUploadImage.Location = new Point(154, 493);
            groupBoxUploadImage.Name = "groupBoxUploadImage";
            groupBoxUploadImage.Size = new Size(268, 61);
            groupBoxUploadImage.TabIndex = 19;
            groupBoxUploadImage.TabStop = false;
            groupBoxUploadImage.Text = "Upload Image";
            // 
            // textBoxFileName
            // 
            textBoxFileName.Location = new Point(6, 22);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(226, 23);
            textBoxFileName.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(238, 21);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(24, 24);
            buttonBrowse.TabIndex = 0;
            buttonBrowse.Text = "...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // openFileDialogUploadImage
            // 
            openFileDialogUploadImage.FileName = "openFileDialogUploadImage";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 626);
            Controls.Add(groupBoxUploadImage);
            Controls.Add(panel1);
            Controls.Add(CancelBtn);
            Controls.Add(InstructionsBox);
            Controls.Add(AddBtn);
            Controls.Add(IngredientBox);
            Controls.Add(label6);
            Controls.Add(DifficultyBox);
            Controls.Add(PortionsBox);
            Controls.Add(TypeBox);
            Controls.Add(NameBox);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New recipe";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)PortionsBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DifficultyBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxUploadImage.ResumeLayout(false);
            groupBoxUploadImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameBox;
        private Label label2;
        private Label label3;
        private TextBox TypeBox;
        private Label label4;
        private NumericUpDown PortionsBox;
        private NumericUpDown DifficultyBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox IngredientBox;
        private TextBox InstructionsBox;
        private Label label8;
        private Button AddBtn;
        private Button CancelBtn;
        private Label label9;
        private Panel panel1;
        private GroupBox groupBoxUploadImage;
        private Button buttonBrowse;
        private OpenFileDialog openFileDialogUploadImage;
        private TextBox textBoxFileName;
        private Label label10;
        private Label label11;
    }
}