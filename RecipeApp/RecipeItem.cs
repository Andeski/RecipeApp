using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RecipeApp
{
    public partial class RecipeItem : UserControl
    {
        public RecipeItem()
        {
            InitializeComponent();
        }

        public string FoodName { get; set; }
        public string DifficultyLabel { get; set; }
        public string PortionLabel { get; set; }
        public Image ImageItem { get; set; }


        private void RecipeItem_Load(object sender, EventArgs e)
        {
            label1.Text = FoodName;
            label2.Text = "Difficulty: " + DifficultyLabel;
            label3.Text = "Portions: " + PortionLabel;
            pictureBox1.Image = ImageItem;
        }

        private void RecipeItem_Click(object sender, EventArgs e)
        {
            //Form1.instanssi.
            string foodName = label1.Text;
            Trace.WriteLine(foodName);
            Food food = Form1.instanssi.foods.FirstOrDefault(f => f.name == foodName);
            RecipeDetailsForm recipeDetailsForm = new RecipeDetailsForm();
            recipeDetailsForm.StartPosition = FormStartPosition.CenterParent;
            recipeDetailsForm.Show();
            recipeDetailsForm.doStuff(food);
        }
    }
}
