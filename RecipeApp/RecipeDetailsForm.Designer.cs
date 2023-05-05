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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsCheckBoxList
            // 
            this.instructionsCheckBoxList.FormattingEnabled = true;
            this.instructionsCheckBoxList.Location = new System.Drawing.Point(12, 352);
            this.instructionsCheckBoxList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.instructionsCheckBoxList.Name = "instructionsCheckBoxList";
            this.instructionsCheckBoxList.Size = new System.Drawing.Size(643, 356);
            this.instructionsCheckBoxList.TabIndex = 0;
            // 
            // ingredientsCheckBoxList
            // 
            this.ingredientsCheckBoxList.FormattingEnabled = true;
            this.ingredientsCheckBoxList.Location = new System.Drawing.Point(12, 16);
            this.ingredientsCheckBoxList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ingredientsCheckBoxList.Name = "ingredientsCheckBoxList";
            this.ingredientsCheckBoxList.Size = new System.Drawing.Size(643, 202);
            this.ingredientsCheckBoxList.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(12, 236);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(643, 99);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 727);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 405);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RecipeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(667, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ingredientsCheckBoxList);
            this.Controls.Add(this.instructionsCheckBoxList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecipeDetailsForm";
            this.Text = "RecipeDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox instructionsCheckBoxList;
        private CheckedListBox ingredientsCheckBoxList;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private PictureBox pictureBox1;
    }
}