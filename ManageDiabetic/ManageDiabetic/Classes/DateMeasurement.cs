/* DateMeasurement.cs
 * By Steven Avila
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageDiabetic.Classes
{
    public class DateMeasurement
    {
        public DateTime date { get; private set; }
        public List<TimeMeasurement> timeMeasurements { get; private set; }

        public DateMeasurement(DateTime date)
        {
            this.date = date;
            timeMeasurements = new List<TimeMeasurement>();
        }
        public DateMeasurement(DateTime date, List<TimeMeasurement> timeMeasurements)
        {
            this.date = date;
            this.timeMeasurements = timeMeasurements;
        }

        public void addTimeMeasurement(TimeMeasurement measurementToAdd)
        {
            timeMeasurements.Add(measurementToAdd);
        }
    }
}
