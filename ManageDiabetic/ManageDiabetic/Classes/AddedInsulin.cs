/* AddedInsulin.cs
 * By Steven Avila
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageDiabetic.Classes
{
    public class AddedInsulin
    {
        public InsulinType Insulin { get; private set; }
        public double Amount { get; private set; }

        public AddedInsulin(InsulinType insulin, int? amount)
        {
            this.Insulin = insulin;
            this.Amount = amount.HasValue ? amount.Value : 0;
        }
        
        public AddedInsulin()
        {

        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Insulin).Append(" ").Append(Amount);
            return sb.ToString();
        }
    }
}
