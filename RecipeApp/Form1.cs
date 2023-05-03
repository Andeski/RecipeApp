using Newtonsoft.Json;

namespace RecipeApp
{

    public partial class Form1 : Form
    {

        private List<Food> foods;
        AddForm addForm;
        public Form1()
        {   //initialize/subscribe events on load
            InitializeComponent();
            listView1.View = View.List;
            listView1.MouseClick += listView1_MouseClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read .json
            string path = Path.Combine(Application.StartupPath, "recipes.json");
            string json = File.ReadAllText(path);
            foods = JsonConvert.DeserializeObject<List<Food>>(json);
            ListViewItem item = null;
            //clear any useless items
            listView1.Items.Clear();

            //set the column header text
            listView1.Columns.Add("Food Name"); //Does not work, miksi?? Jos poistaa koko paska hajoo :D (1/3)

            //set the auto-resize mode for columns
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //(2/3)
            listView1.Columns[0].Width = -1; //(3/3)


            foreach (Food food in foods)
            {

                //create a new listview item with the food name as the text
                item = new ListViewItem(food.name);

                //add sub-items for each ingredient and instruction
                foreach (string ingredient in food.ingredients)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, ingredient));
                }

                foreach (string instruction in food.instructions)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, instruction));
                }

                //add the item to the listview object
                listView1.Items.Add(item);

                //fixing the truncated/bunched up text with this //( huhhuh pitk� s��t�:
                int foodNameWidth = TextRenderer.MeasureText(item.Text, listView1.Font).Width;
                int otherColumnsWidth = listView1.Columns.Cast<ColumnHeader>().Skip(1).Sum(c => c.Width);
                int padding = listView1.ClientSize.Width - otherColumnsWidth - SystemInformation.VerticalScrollBarWidth;
                listView1.Columns[0].Width = Math.Max(foodNameWidth + padding, listView1.Columns[0].Width);
                //)
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                //create a new form to display the food details
                FoodDetailsForm detailsForm = new FoodDetailsForm(food);
                detailsForm.Show();
            }
        }

        //create details window on click
        public partial class FoodDetailsForm : Form
        {
            public FoodDetailsForm(Food food)
            {
                //set title of window to the name of the selected food
                Text = food.name;

                //create a table layout panel to hold controls
                TableLayoutPanel table = new TableLayoutPanel();
                table.Dock = DockStyle.Fill;
                table.AutoSize = true;
                table.AutoScroll = true;
                table.ColumnCount = 1;
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

                //display ingredients
                string ingredients = string.Join(Environment.NewLine, food.ingredients);
                Label ingredientsLabel = new Label
                {
                    Text = $"Ingredients:{Environment.NewLine}{ingredients}",
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };
                table.Controls.Add(ingredientsLabel, 0, 0);

                //display difficulty
                string difficulty = string.Join(Environment.NewLine, food.difficulty);
                Label diffLabel = new Label
                {
                    Text = $"\nDifficulty:{Environment.NewLine}{difficulty}",
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };
                table.Controls.Add(diffLabel, 0, 1);

                //display portions
                string portions = string.Join(Environment.NewLine, food.portions);
                Label portionLabel = new Label
                {
                    Text = $"\nPortions:{Environment.NewLine}{portions}",
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };
                table.Controls.Add(portionLabel, 0, 1);

                //display instructions
                string instructions = string.Join(Environment.NewLine, food.instructions);
                Label instructionsLabel = new Label
                {
                    Text = $"\nInstructions:{Environment.NewLine}{instructions}",
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };
                table.Controls.Add(instructionsLabel, 0, 2);

                //add table layout panel to the form
                Controls.Add(table);
            }
        }

        //Luo lis�ys Formin (uuden ikkunan)
        private void Add_Click(object sender, EventArgs e)
        {
            addForm = new AddForm();
            addForm.Show();
        }
    }
}