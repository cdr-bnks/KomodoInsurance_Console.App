using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Library
{
  public class DevTeam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool PSAccess { get; set; }
        public int AccessCode { get; set; }
       
        public DevTeam()
        {

        }

        public DevTeam(int id, string name, double salary, bool DevAccess, int aid )
        {
            ID = id;
            Name = name;
            Salary = salary;
            PSAccess = DevAccess;
            AccessCode = aid;

        }
    }
}
