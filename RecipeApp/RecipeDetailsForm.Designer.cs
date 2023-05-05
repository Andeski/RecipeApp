namespace RecipeApp
{
    partial class RecipeDetailsForm
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
            this.instructionsCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.ingredientsCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // instructionsCheckBoxList
            // 
            this.instructionsCheckBoxList.FormattingEnabled = true;
            this.instructionsCheckBoxList.Location = new System.Drawing.Point(10, 264);
            this.instructionsCheckBoxList.Name = "instructionsCheckBoxList";
            this.instructionsCheckBoxList.Size = new System.Drawing.Size(563, 256);
            this.instructionsCheckBoxList.TabIndex = 0;
            // 
            // ingredientsCheckBoxList
            // 
            this.ingredientsCheckBoxList.FormattingEnabled = true;
            this.ingredientsCheckBoxList.Location = new System.Drawing.Point(10, 12);
            this.ingredientsCheckBoxList.Name = "ingredientsCheckBoxList";
            this.ingredientsCheckBoxList.Size = new System.Drawing.Size(563, 148);
            this.ingredientsCheckBoxList.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(10, 177);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 75);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "jkscd";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "dfmk";
            this.columnHeader2.Width = 300;
            // 
            // RecipeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(584, 529);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ingredientsCheckBoxList);
            this.Controls.Add(this.instructionsCheckBoxList);
            this.Name = "RecipeDetailsForm";
            this.Text = "RecipeDetailsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox instructionsCheckBoxList;
        private CheckedListBox ingredientsCheckBoxList;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}