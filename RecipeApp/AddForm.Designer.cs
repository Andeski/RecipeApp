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
            ((System.ComponentModel.ISupportInitialize)PortionsBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DifficultyBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 0;
            label1.Text = "Add your own recipe";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(95, 47);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(200, 23);
            NameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 50);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 76);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Type:";
            // 
            // TypeBox
            // 
            TypeBox.Location = new Point(95, 76);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(200, 23);
            TypeBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 106);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Portions:";
            // 
            // PortionsBox
            // 
            PortionsBox.Location = new Point(95, 104);
            PortionsBox.Name = "PortionsBox";
            PortionsBox.Size = new Size(45, 23);
            PortionsBox.TabIndex = 6;
            // 
            // DifficultyBox
            // 
            DifficultyBox.Location = new Point(95, 134);
            DifficultyBox.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            DifficultyBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DifficultyBox.Name = "DifficultyBox";
            DifficultyBox.Size = new Size(45, 23);
            DifficultyBox.TabIndex = 8;
            DifficultyBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 136);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 7;
            label5.Text = "Difficulty:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 136);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 9;
            label6.Text = "(1 easy - 5 difficult)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 163);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 11;
            label7.Text = "Ingredients:";
            // 
            // IngredientBox
            // 
            IngredientBox.Location = new Point(95, 163);
            IngredientBox.Multiline = true;
            IngredientBox.Name = "IngredientBox";
            IngredientBox.Size = new Size(200, 154);
            IngredientBox.TabIndex = 12;
            // 
            // InstructionsBox
            // 
            InstructionsBox.Location = new Point(95, 323);
            InstructionsBox.Multiline = true;
            InstructionsBox.Name = "InstructionsBox";
            InstructionsBox.Size = new Size(200, 154);
            InstructionsBox.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 323);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 13;
            label8.Text = "Instructions:";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(97, 481);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(79, 38);
            AddBtn.TabIndex = 15;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(12, 481);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(79, 38);
            CancelBtn.TabIndex = 16;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 524);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(InstructionsBox);
            Controls.Add(label8);
            Controls.Add(IngredientBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(DifficultyBox);
            Controls.Add(label5);
            Controls.Add(PortionsBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TypeBox);
            Controls.Add(label2);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)PortionsBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DifficultyBox).EndInit();
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
    }
}