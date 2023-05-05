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
        public int newImageName = 0;
        public string defaultImage = @"Resources\BananaPancakes.jpg";
        public AddForm()
        {
            InitializeComponent();
            openFileDialogUploadImage.FileName = defaultImage;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UploadImage();
            List<Food> list = new List<Food>();
            StreamReader sr = new StreamReader(filePath);
            string currentJson = sr.ReadToEnd();
            list = JsonConvert.DeserializeObject<List<Food>>(currentJson);
            sr.Close();

            string IngredientInput = IngredientBox.Text;
            string[] IngredientArray = IngredientInput.Split(',');
            string InstructionsInput = InstructionsBox.Text;
            string[] InstructionsArray = InstructionsInput.Split(',');

            Food newRecipe = new Food()
            {
                name = NameBox.Text,
                type = TypeBox.Text,
                portions = PortionsBox.Value.ToString(),
                difficulty = DifficultyBox.Value.ToString(),
                ingredients = IngredientArray,
                instructions = InstructionsArray,
                //ingredients = new List<string> { IngredientBox.Text },
                //instructions = new List<string> { InstructionsBox.Text },
                imagePath = Path.GetFileName(textBoxFileName.Text),
            };

            //if (newRecipe.imagePath == "")
            //{
            //    newRecipe = new Food()
            //    {
            //        name = NameBox.Text,
            //        type = TypeBox.Text,
            //        portions = PortionsBox.Value.ToString(),
            //        difficulty = DifficultyBox.Value.ToString(),
            //        ingredients = IngredientArray,
            //        instructions = InstructionsArray,
            //        imagePath = defaultImage
            //    };
            //}

            list.Add(newRecipe);

            StreamWriter sw = new StreamWriter(filePath);
            string newJson = JsonConvert.SerializeObject(list);
            sw.Write(newJson);
            sw.Close();
            Form1 form = new Form1();
            Form1.instanssi.Refresh();
            Form1.instanssi.InsertRecipes();
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
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void UploadImage()
        {
            string fileName = Path.GetFileName(openFileDialogUploadImage.FileName);
            string folderPath = Path.Combine(Application.StartupPath + @"Resources\");
            string curFilePath = openFileDialogUploadImage.FileName;
            //if (fileName == "openFileDialogUploadImage")
            //{
            //    fileName = defaultImage;
            //    curFilePath = folderPath;
            //}
            string copiedFilePath = folderPath + fileName;
            //if (!(curFilePath == copiedFilePath))
            //{
                
            //}
            File.Copy(curFilePath, copiedFilePath, true);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogUploadImage.InitialDirectory = @"C:\";
                openFileDialogUploadImage.Title = "Select an image to upload";
                openFileDialogUploadImage.FileName = String.Empty;
                openFileDialogUploadImage.ShowHelp = false;
                openFileDialogUploadImage.Filter = "Image Files(*.PNG;*.JPG;)|*.PNG;*.JPG |All Files (*.*)|*.*";
                DialogResult _result = openFileDialogUploadImage.ShowDialog();
                if (_result == DialogResult.Cancel)
                {

                }
                else
                {
                    textBoxFileName.Text = openFileDialogUploadImage.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
