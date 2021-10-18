using KomodoInsuranceConsole.App.Emlpoyee_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceConsole.App
{
    
   public class Developer
    {
        public int ID { get; set; }
        public  string  Name { get; set; }
        public double Salary { get; set; }
        public bool PSAccess { get; set; }

        


        public Developer(int id, string name, double salary, bool devAccess)
        {
            ID = id;
            Name = name;
            Salary = salary;
            PSAccess = devAccess;
            
        }
       




    }
    
}
