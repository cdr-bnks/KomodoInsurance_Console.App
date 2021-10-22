using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Library
{
    public class Developer : Employee
    {
        public bool PSAccess { get; set; }
        public int AccessCode { get; set; }
        

        public override  void DataLog()
        {

            base.DataLog();

        }

       public Developer(int id, string name, double salary, bool devAccess, int aid )
            :base(id, name, salary)
        {
            
            PSAccess = devAccess;
            AccessCode = aid;
        }

        public static implicit operator Developer(KeyValuePair<int, Developer> v)
        {
            throw new NotImplementedException();
        }

        
            
        
    }
}