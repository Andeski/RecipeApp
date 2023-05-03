using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class AddForm : Form
    {
        //joo
        public string filePath = Path.Combine(Application.StartupPath, "recipes.json");
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            List<Food> list = new List<Food>();
            StreamReader sr = new StreamReader(filePath);
            string currentJson = sr.ReadToEnd();
            list = JsonConvert.DeserializeObject<List<Food>>(currentJson);
            sr.Close();
            
            Food newRecipe = new Food() 
            {
                name = NameBox.Text,
                type = TypeBox.Text,
                portions = PortionsBox.Value.ToString(),
                difficulty = DifficultyBox.Value.ToString(),
                ingredients = new List<string> { IngredientBox.Text },
                instructions = new List<string> { InstructionsBox.Text }
            };

            list.Add(newRecipe);

            StreamWriter sw = new StreamWriter(filePath);
            string newJson = JsonConvert.SerializeObject(list);
            Trace.WriteLine(newJson);
            sw.Write(newJson);
            sw.Close();

            //foreach (Food i in list)
            //{
            //    Trace.WriteLine(i.name + "\n");
            //    foreach (string s in i.ingredients)
            //        Trace.WriteLine(s);
            //    Trace.WriteLine("");
            //    foreach (string a in i.instructions)
            //        Trace.WriteLine(a);
            //    Trace.WriteLine("");
            //}
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
