using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Library
{
    class DevTeam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public DevTeam(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
    }
}
