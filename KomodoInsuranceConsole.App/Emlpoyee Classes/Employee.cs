using KomodoInsuranceConsole.App.Emlpoyee_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceConsole.App.Emlpoyee_Classes
{
   public class Employee : IAccess
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool PSAccess { get; set; }

        public string Access()
        {
            PSAccess = true;
            return "Authorized access"; 
        }
        public Employee(int id, string name, double salary, bool devAccess)
        {
            ID = id;
            Name = name;
            Salary = salary;
            PSAccess = devAccess;

        }
        Employee developerOne = new Employee(1, "H,Micheal", 88000, true);
        Employee developerTwo = new Employee(2, "H,Micheal", 90000, false);
        Employee developerThree = new Employee(3, "H,Micheal", 80000, true);
        Employee developerFour = new Employee(4, "H,Micheal", 62000, true);
        Employee developerFive = new Employee(5, "H,Micheal", 89000, true);
        Employee developerSix = new Employee(6, "H,Micheal", 99000, false);
        Employee developerSeven = new Employee(7, "H,Micheal", 100000, true);
        Employee developerEight = new Employee(8, "H,Micheal", 77000, true);
        Employee developerNine = new Employee(9, "H,Micheal", 95000, true);
        Employee developerTen = new Employee(10, "H,Micheal", 85000, false);
        Employee developerElven = new Employee(11, "H,Micheal", 75000, true);
        Employee developerTwelve = new Employee(12, "H,Micheal", 55000, false);

        
    }
}
