using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
    public class FoodItem
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }

        public FoodItem(string name, double calories, double fat, double carbohydrates)
        {
            Name = name;
            Calories = calories;
            Fat = fat;
            Carbohydrates = carbohydrates;
        }
    }
}
