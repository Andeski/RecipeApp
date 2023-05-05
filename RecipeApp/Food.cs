using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class Food
    {
        public string name { get; set; }
        public string type { get; set; }
        public string portions { get; set; }
        public string difficulty { get; set; }
        public string[] ingredients { get; set; }
        public string[] instructions { get; set; }
        public string imagePath { get; set; }
    }
}
