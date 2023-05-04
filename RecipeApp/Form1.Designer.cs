namespace RecipeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAddRecipe = new Button();
            txtRecipeName = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            NewFLPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label1 = new Label();
            Add = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(NewFLPanel);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 625);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Controls.Add(btnAddRecipe);
            flowLayoutPanel1.Controls.Add(txtRecipeName);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(227, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(537, 30);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.FlatAppearance.BorderSize = 0;
            btnAddRecipe.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
            btnAddRecipe.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRecipe.ForeColor = Color.Black;
            btnAddRecipe.Location = new Point(431, 3);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(103, 23);
            btnAddRecipe.TabIndex = 3;
            btnAddRecipe.Text = "Find";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += FindBtn_Click;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(44, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.PlaceholderText = "Find a recipe...";
            txtRecipeName.Size = new Size(381, 23);
            txtRecipeName.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.YellowGreen;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(220, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(581, 43);
            panel3.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 40);
            label2.TabIndex = 10;
            label2.Text = "Foods:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // NewFLPanel
            // 
            NewFLPanel.AutoScroll = true;
            NewFLPanel.Location = new Point(227, 79);
            NewFLPanel.MinimumSize = new Size(50, 50);
            NewFLPanel.Name = "NewFLPanel";
            NewFLPanel.Size = new Size(537, 543);
            NewFLPanel.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.YellowGreen;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Add);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 625);
            panel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(-1, 156);
            button1.Name = "button1";
            button1.Size = new Size(222, 50);
            button1.TabIndex = 7;
            button1.Text = "All Recipes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AllRecipesBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(-1, 268);
            button3.Name = "button3";
            button3.Size = new Size(222, 50);
            button3.TabIndex = 9;
            button3.Text = "Placeholder";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(198, 65);
            label1.TabIndex = 0;
            label1.Text = "Recipes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Add
            // 
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Add.ForeColor = SystemColors.Control;
            Add.Location = new Point(-1, 100);
            Add.Name = "Add";
            Add.Size = new Size(222, 50);
            Add.TabIndex = 5;
            Add.Text = "Add Recipe";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(0, 212);
            button2.Name = "button2";
            button2.Size = new Size(222, 50);
            button2.TabIndex = 8;
            button2.Text = "Placeholder";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnAddRecipe;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 619);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe App";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtRecipeName;
        private Button btnAddRecipe;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Add;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private FlowLayoutPanel NewFLPanel;
        private Panel panel3;
        private Label label2;
    }
}