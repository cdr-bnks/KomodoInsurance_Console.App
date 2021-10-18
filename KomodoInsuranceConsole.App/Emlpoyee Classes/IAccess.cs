using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceConsole.App.Emlpoyee_classes
{
    public interface IAccess
    {
         int ID { get;  }
         string Name { get; set; }
        double Salary { get; set; }
        bool PSAccess { get; set; }

         string Access();
    }
}
