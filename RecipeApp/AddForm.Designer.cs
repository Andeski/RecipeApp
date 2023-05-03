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
            ((System.ComponentModel.ISupportInitialize)(this.PortionsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add your own recipe";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(95, 47);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(200, 23);
            this.NameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type:";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(95, 76);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(200, 23);
            this.TypeBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Portions:";
            // 
            // PortionsBox
            // 
            this.PortionsBox.Location = new System.Drawing.Point(95, 104);
            this.PortionsBox.Name = "PortionsBox";
            this.PortionsBox.Size = new System.Drawing.Size(45, 23);
            this.PortionsBox.TabIndex = 6;
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.Location = new System.Drawing.Point(95, 134);
            this.DifficultyBox.Maximum = new decimal(new int[] {
            5,
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
            this.label5.Location = new System.Drawing.Point(23, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Difficulty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "(1 easy - 5 difficult)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingredients:";
            // 
            // IngredientBox
            // 
            this.IngredientBox.Location = new System.Drawing.Point(95, 163);
            this.IngredientBox.Multiline = true;
            this.IngredientBox.Name = "IngredientBox";
            this.IngredientBox.Size = new System.Drawing.Size(200, 154);
            this.IngredientBox.TabIndex = 12;
            // 
            // InstructionsBox
            // 
            this.InstructionsBox.Location = new System.Drawing.Point(95, 323);
            this.InstructionsBox.Multiline = true;
            this.InstructionsBox.Name = "InstructionsBox";
            this.InstructionsBox.Size = new System.Drawing.Size(200, 154);
            this.InstructionsBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Instructions:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(97, 481);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(79, 38);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(12, 481);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(79, 38);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 524);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.InstructionsBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IngredientBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PortionsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.PortionsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyBox)).EndInit();
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
    }
}