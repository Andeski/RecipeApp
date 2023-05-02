using Newtonsoft.Json;

namespace RecipeApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listView1_SelectedIndexChanged();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public class Food
        {
            public string name { get; set; }
            public List<string> ingredients { get; set; }
            public List<string> instructions { get; set; }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string json = File.ReadAllText("foods.json");
            List<Food> foods = JsonConvert.DeserializeObject<List<Food>>(json);

            foreach (Food food in foods)
            {
                // create a new listview item with the food name as the text
                ListViewItem item = new ListViewItem(food.name);

                // add sub-items for each ingredient and instruction
                foreach (string ingredient in food.ingredients)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, ingredient));
                }

                foreach (string instruction in food.instructions)
                {
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, instruction));
                }

                // add the item to the listview object
                listView1.Items.Add(item);
            }
        }
    }
}