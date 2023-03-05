/* Meal.cs
 * By Steven Avila
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageDiabetic.Classes
{
    public class Meal
    {
        public Food food { get; }

        public double amount { get; }

        public Meal(Food f, double? a)
        {
            this.food = f;
            this.amount = a.HasValue ? a.Value : 0;
        }

        public bool matchingFood(string name, string brand, float carbs)
        {
            return food.Name.Equals(name) && food.Brand.Equals(brand) && food.Carbs.Equals(carbs);
        }
    }
}
