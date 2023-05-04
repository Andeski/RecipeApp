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

        public void doStuff(Food food)
        {
            foreach (var item in food.instructions)
            {
                checkedListBox1.Items.Add(item);
            }
        }
    }

}
