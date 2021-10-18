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
        Employee employeeOne = new Employee(1, "Jackie", 88000, true);
        Employee employeeTwo = new Employee(2, "Gustav", 90000, false);
        Employee employeeThree = new Employee(3, "Yoshiro", 80000, true);
        Employee employeeFour = new Employee(4, "Baki", 62000, true);
        Employee emlpoyeeFive = new Employee(5, "Ali", 89000, true);
        Employee employeeSix = new Employee(6, "Ryu", 99000, false);
        Employee employeeSeven = new Employee(7, "Nola", 100000, true);
        Employee employeeEight = new Employee(8, "Susie", 77000, true);
        Employee employeeNine = new Employee(9, "Jacob", 95000, true);
        Employee employeeTen = new Employee(10, "Caleb", 85000, false);
        Employee employeeElven = new Employee(11, "Drew", 75000, true);
        Employee empployeeTwelve = new Employee(12, "Lola", 55000, false);

        
    }
}
