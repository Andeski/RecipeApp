using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace RecipeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //TESTI TESTI
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnHae(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"\recipes.json"))
            {
                List<Evas> lista = new List<Evas>();
                string jsonString = sr.ReadToEnd();
                lista = JsonConvert.DeserializeObject<List<Evas>>(jsonString);
                foreach (var item in lista)
                {
                    recipeCategories.Items[0].Text = item.Foods;
                }
            }
        }
    }
}