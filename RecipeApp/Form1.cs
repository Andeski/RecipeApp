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
            recipeCategories.Items.Add("Pekkaramaruna");
            recipeCategories.Items.Add("Soppa");
            recipeCategories.Items.Add("Magaroonilaadikko");
            recipeCategories.Items.Add("Parasetamoli");
            recipeCategories.Items.Add("Fentanyylitikkari");
        }
    }
}