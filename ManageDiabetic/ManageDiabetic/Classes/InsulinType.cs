/* InuslinType.cs
 * By Steven Avila
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageDiabetic.Classes
{
    public class InsulinType
    {
        public string Name { get; private set; }
        public string Brand { get; private set; }

        public InsulinType(string name, string brand)
        {
            this.Name = name;
            this.Brand = brand;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType().Equals(this.GetType()))
            {
                InsulinType tmp = (InsulinType)obj;
                if (this.Name.Equals(tmp.Name)
                    && this.Brand.Equals(tmp.Brand))
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = 31 * hash + Name.GetHashCode();
            hash = 31 * hash + Brand.GetHashCode();
            return hash;

        }
        public override string ToString()
        {
            return Name + ", " + Brand;
        }
    }
}
