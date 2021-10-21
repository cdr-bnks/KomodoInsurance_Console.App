using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Library
{
    interface IAccess
    {
        string Name { get; }
        double YearlySubscription { get; set; }
        bool PSAccess { get; set; }

        string Access();
    }
}
