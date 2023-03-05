/* Food.cs
 * By Steven Avila
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageDiabetic
{
    public class Food
    {
        /// <summary>
        /// The name of the food.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The brand who made the food
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// The carbohydrates of the food
        /// </summary>
        public float Carbs { get; private set; }

        /// <summary>
        /// A public class for entering food data.
        /// </summary>
        /// <param name="name">name of the food</param>
        /// <param name="brand">brand of the food</param>
        /// <param name="carbs">carbs in the food</param>
        public Food(string name, string brand, float carbs)
        {
            Name = name;
            Brand = brand;
            Carbs = carbs;
        }

        /// <summary>
        /// Check to 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType().Equals(this.GetType()))
            {
                Food tmp = (Food)obj;
                if (tmp.Name.Equals(this.Name)
                    && tmp.Brand.Equals(this.Brand)
                    && tmp.Carbs.Equals(this.Carbs))
                {
                    return true;
                }
            }
            return false;
        }

        public string[] ToArray()
        {
            return new string[] { Name, Brand, Carbs.ToString() };
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + Name.GetHashCode();
            hash = hash * 31 + Brand.GetHashCode();
            hash = hash * 31 + Carbs.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            return Name + ", " + Brand;
        }
    }
}
