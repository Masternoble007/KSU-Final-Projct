/* TimeMeasurement.cs
 * By Steven Avila
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageDiabetic.Classes
{
    public class TimeMeasurement
    {
        public DateTime time { get; private set; }
        public float measurement { get; set; }
        public AddedInsulin insulinAdded { get; set; }
        public List<Meal> meals { get; set; }

        public TimeMeasurement(DateTime time)
        {
            this.time = time;
            measurement = 0;
            insulinAdded = new AddedInsulin();
            meals = new List<Meal>();
        }

        public TimeMeasurement(DateTime time, float? measurement, AddedInsulin addedInsulin, List<Meal> meals)
        {
            this.time = time;
            this.measurement = measurement.HasValue ? measurement.Value : 0;
            this.insulinAdded = addedInsulin;
            this.meals = meals;
        }
        public TimeMeasurement(DateTime time, float? measurement, AddedInsulin addedInsulin)
        {
            this.time = time;
            this.measurement = measurement.HasValue ? measurement.Value : 0;
            this.insulinAdded = addedInsulin;
            this.meals = new List<Meal>();
        }

        public void addMeal(Meal mealToAdd)
        {
            meals.Add(mealToAdd);
        }
        public bool matchTime(string timeVal)
        {
            return time.ToString("HH:mm").Equals(timeVal);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(time.ToString("HH:mm")).Append(" ").Append(measurement).Append(" ").Append(insulinAdded);
            return sb.ToString();
        }
    }
}
