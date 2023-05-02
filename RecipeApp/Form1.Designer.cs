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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Center);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.recipeCategories = new System.Windows.Forms.ListView();
            this.Recipe = new System.Windows.Forms.ColumnHeader();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reseptit";
            // 
            // recipeCategories
            // 
            this.recipeCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Recipe});
            this.recipeCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipeCategories.FullRowSelect = true;
            this.recipeCategories.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Subtitle = "asd";
            this.recipeCategories.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.recipeCategories.Location = new System.Drawing.Point(0, 84);
            this.recipeCategories.Name = "recipeCategories";
            this.recipeCategories.ShowGroups = false;
            this.recipeCategories.Size = new System.Drawing.Size(344, 476);
            this.recipeCategories.TabIndex = 1;
            this.recipeCategories.TileSize = new System.Drawing.Size(48, 48);
            this.recipeCategories.UseCompatibleStateImageBehavior = false;
            this.recipeCategories.View = System.Windows.Forms.View.Details;
            // 
            // Recipe
            // 
            this.Recipe.Tag = "Test1";
            this.Recipe.Text = "Recipe";
            this.Recipe.Width = 300;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(12, 566);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.PlaceholderText = "Tee uusi resepti...";
            this.txtRecipeName.Size = new System.Drawing.Size(239, 23);
            this.txtRecipeName.TabIndex = 2;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(257, 566);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipe.TabIndex = 3;
            this.btnAddRecipe.Text = "Find";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.recipeCategories);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListView recipeCategories;
        private ColumnHeader Recipe;
        private TextBox txtRecipeName;
        private Button btnAddRecipe;
    }
}