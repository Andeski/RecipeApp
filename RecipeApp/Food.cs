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
        public List<string> ingredients { get; set; }
        public List<string> instructions { get; set; }
    }
}
