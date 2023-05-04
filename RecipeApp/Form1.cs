using Newtonsoft.Json;

namespace RecipeApp
{

    public partial class Form1 : Form
    {
        public static Form1 instanssi;
        public List<Food> foods;
        AddForm addForm;

        public Form1()
        {   //initialize/subscribe events on load
            InitializeComponent();
            instanssi = this;
            listView1.View = View.Details;
            listView1.MouseClick += listView1_MouseClick;
            //listView1.Columns.Add("Food Name"); //Jos poistaa koko paska hajoo :D (1/3)
        }

        public void InsertRecipes()
        {
            //read .json
            string path = Path.Combine(Application.StartupPath, "recipes.json");
            string json = File.ReadAllText(path);
            //List<Food> newFoods = new List<Food>();
            
            foods = JsonConvert.DeserializeObject<List<Food>>(json);
        }

        public void PrintRecipes()
        {
            InsertRecipes();
            ListViewItem item = null;
            //clear any useless items
            listView1.Items.Clear();

            //set the column header text

            //set the auto-resize mode for columns
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //(2/3)
            //listView1.Columns[0].Width = -1; //(3/3) Jos column määrä on NULL tulee fatal error, yksi column on luotava
            
            foreach (Food food in foods)
            {
                //create a new listview item with the food name as the text
                item = new ListViewItem(food.name);
                item.Font = new Font(item.Font, FontStyle.Regular);
                //add the item to the listview object
                listView1.Items.Add(item);

                //fixing the truncated/bunched up text with this //( huhhuh pitkä säätö:
                //int foodNameWidth = TextRenderer.MeasureText(item.Text, listView1.Font).Width;
                //int otherColumnsWidth = listView1.Columns.Cast<ColumnHeader>().Skip(1).Sum(c => c.Width);
                //int padding = listView1.ClientSize.Width - otherColumnsWidth - SystemInformation.VerticalScrollBarWidth;
                //listView1.Columns[0].Width = Math.Max(foodNameWidth + padding, listView1.Columns[0].Width);
            }

            listView1.Columns[0].Text = listView1.Items.Count.ToString() + " Recipes listed";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintRecipes();
        }



        //make text react to click
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //check if any items are selected
            {
                ListViewItem selected = listView1.SelectedItems[0];
                string foodName = selected.Text;

                //find the food item that matches the selected name
                Food food = foods.FirstOrDefault(f => f.name == foodName);

                ////create a new form to display the food details
                //FoodDetailsForm detailsForm = new FoodDetailsForm(food);
                //detailsForm.Show();
                RecipeDetailsForm recipeDetailsForm = new RecipeDetailsForm();
                recipeDetailsForm.Show();
                recipeDetailsForm.doStuff(food);
            }
        }

        ////create details window on click
        //public partial class FoodDetailsForm : Form
        //{
        //    public FoodDetailsForm(Food food)
        //    {
        //        Size = new Size(450, 750);
        //        //set title of window to the name of the selected food
        //        Text = food.name;

        //        //create a table layout panel to hold controls
        //        TableLayoutPanel table = new TableLayoutPanel();
        //        table.Dock = DockStyle.Fill;
        //        table.AutoSize = true;
        //        table.AutoScroll = true;
        //        table.ColumnCount = 1;
        //        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

        //        //display ingredients
        //        string ingredients = string.Join(Environment.NewLine, food.ingredients);
        //        Label ingredientsLabel = new Label
        //        {
        //            Text = $"Ingredients:{Environment.NewLine}{ingredients}",
        //            Dock = DockStyle.Fill,
        //            AutoSize = true
        //        };
        //        table.Controls.Add(ingredientsLabel, 0, 0);

        //        //display difficulty
        //        string difficulty = string.Join(Environment.NewLine, food.difficulty);
        //        Label diffLabel = new Label
        //        {
        //            Text = $"\nDifficulty:{Environment.NewLine}{difficulty}",
        //            Dock = DockStyle.Fill,
        //            AutoSize = true
        //        };
        //        table.Controls.Add(diffLabel, 0, 1);

        //        //display portions
        //        string portions = string.Join(Environment.NewLine, food.portions);
        //        Label portionLabel = new Label
        //        {
        //            Text = $"\nPortions:{Environment.NewLine}{portions}",
        //            Dock = DockStyle.Fill,
        //            AutoSize = true
        //        };
        //        table.Controls.Add(portionLabel, 0, 1);

        //        //display instructions
        //        string instructions = string.Join(Environment.NewLine, food.instructions);
        //        Label instructionsLabel = new Label
        //        {
        //            Text = $"\nInstructions:{Environment.NewLine}{instructions}",
        //            Dock = DockStyle.Fill,
        //            AutoSize = true
        //        };
        //        table.Controls.Add(instructionsLabel, 0, 2);

        //        //add table layout panel to the form
        //        Controls.Add(table);
        //    }
        //}

        //Luo lisäys Formin (uuden ikkunan)
        private void Add_Click(object sender, EventArgs e)
        {
            addForm = new AddForm();
            addForm.Show();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string searchable = txtRecipeName.Text;

            if (searchable.Count() > 0)
            {
                var search = from a in foods
                             where a.name.ToUpper().Contains(searchable.ToUpper()) || a.type.ToLower().Contains(searchable.ToLower()) ||
                             a.portions.Contains(searchable) || a.difficulty.Contains(searchable) ||
                             a.ingredients.Contains(searchable) || a.instructions.Contains(searchable)
                             select a;
                
                listView1.Items.Clear();

                foreach (var i in search)
                {
                    var item = new ListViewItem(i.name);
                    item.Font = new Font(item.Font, FontStyle.Regular);
                    listView1.Items.Add(item);
                    listView1.Font = new Font(listView1.Font, FontStyle.Regular);
                }
            }
            else
                PrintRecipes();
        }

        private void AllRecipesBtn_Click(object sender, EventArgs e)
        {
            PrintRecipes();
        }
    }
}