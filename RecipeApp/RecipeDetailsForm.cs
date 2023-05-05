using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class RecipeDetailsForm : Form
    {
        public RecipeDetailsForm()
        {
            InitializeComponent();
        }

        public void DoStuff(Food food)
        {
            ListViewItem portions = new ListViewItem("Portions");
            portions.SubItems.Add(food.portions);
            listView1.Items.Add(portions);
            ListViewItem difficulty = new ListViewItem("Difficulty");
            difficulty.SubItems.Add(food.difficulty);
            listView1.Items.Add(difficulty);

            foreach (var item in food.ingredients)
            {
                ingredientsCheckBoxList.Items.Add(item);
            }
            foreach (var item in food.instructions)
            {
                instructionsCheckBoxList.Items.Add(item);
            }
        }
    }

}
