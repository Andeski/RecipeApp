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
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PortionsBox = new System.Windows.Forms.NumericUpDown();
            this.DifficultyBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IngredientBox = new System.Windows.Forms.TextBox();
            this.InstructionsBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxUploadImage = new System.Windows.Forms.GroupBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialogUploadImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PortionsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxUploadImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add your own recipe";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(151, 51);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(271, 23);
            this.NameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type:";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(151, 80);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(271, 23);
            this.TypeBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Portions:";
            // 
            // PortionsBox
            // 
            this.PortionsBox.Location = new System.Drawing.Point(151, 108);
            this.PortionsBox.Name = "PortionsBox";
            this.PortionsBox.Size = new System.Drawing.Size(45, 23);
            this.PortionsBox.TabIndex = 6;
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.Location = new System.Drawing.Point(151, 138);
            this.DifficultyBox.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DifficultyBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(45, 23);
            this.DifficultyBox.TabIndex = 8;
            this.DifficultyBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Difficulty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "(1 easy - 3 difficult)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingredients:";
            // 
            // IngredientBox
            // 
            this.IngredientBox.Location = new System.Drawing.Point(151, 167);
            this.IngredientBox.Multiline = true;
            this.IngredientBox.Name = "IngredientBox";
            this.IngredientBox.Size = new System.Drawing.Size(271, 154);
            this.IngredientBox.TabIndex = 12;
            // 
            // InstructionsBox
            // 
            this.InstructionsBox.Location = new System.Drawing.Point(151, 327);
            this.InstructionsBox.Multiline = true;
            this.InstructionsBox.Name = "InstructionsBox";
            this.InstructionsBox.Size = new System.Drawing.Size(271, 154);
            this.InstructionsBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Instructions:";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(343, 576);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(79, 38);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(257, 576);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(79, 38);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Close";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(54, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Image:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 626);
            this.panel1.TabIndex = 18;
            // 
            // groupBoxUploadImage
            // 
            this.groupBoxUploadImage.Controls.Add(this.textBoxFileName);
            this.groupBoxUploadImage.Controls.Add(this.buttonBrowse);
            this.groupBoxUploadImage.Location = new System.Drawing.Point(154, 493);
            this.groupBoxUploadImage.Name = "groupBoxUploadImage";
            this.groupBoxUploadImage.Size = new System.Drawing.Size(268, 61);
            this.groupBoxUploadImage.TabIndex = 19;
            this.groupBoxUploadImage.TabStop = false;
            this.groupBoxUploadImage.Text = "Upload Image";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(6, 22);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(226, 23);
            this.textBoxFileName.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(238, 21);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(24, 24);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialogUploadImage
            // 
            this.openFileDialogUploadImage.FileName = "openFileDialogUploadImage";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 626);
            this.Controls.Add(this.groupBoxUploadImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.InstructionsBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.IngredientBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.PortionsBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.Text = "New recipe";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PortionsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxUploadImage.ResumeLayout(false);
            this.groupBoxUploadImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}