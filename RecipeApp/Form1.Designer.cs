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
            ListViewItem listViewItem1 = new ListViewItem("");
            panel1 = new Panel();
            label1 = new Label();
            listView1 = new ListView();
            txtRecipeName = new TextBox();
            btnAddRecipe = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 18);
            label1.Name = "label1";
            label1.Size = new Size(150, 47);
            label1.TabIndex = 0;
            label1.Text = "Reseptit";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            listView1.Cursor = Cursors.IBeam;
            listView1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(12, 84);
            listView1.Name = "listView1";
            listView1.RightToLeft = RightToLeft.No;
            listView1.Size = new Size(472, 295);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(12, 566);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.PlaceholderText = "Find a recipe...";
            txtRecipeName.Size = new Size(239, 23);
            txtRecipeName.TabIndex = 2;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(257, 566);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(75, 23);
            btnAddRecipe.TabIndex = 3;
            btnAddRecipe.Text = "Find";
            btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 397);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(472, 152);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 599);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAddRecipe);
            Controls.Add(txtRecipeName);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListView listView1;
        private TextBox txtRecipeName;
        private Button btnAddRecipe;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}