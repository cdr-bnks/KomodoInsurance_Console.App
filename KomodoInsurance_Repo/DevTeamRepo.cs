using KomodoInsurance.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Repo
{
    class DevTeamRepo
    {
        protected readonly Dictionary<int, DevTeam> _devTeamDirectory= new Dictionary<int, DevTeam>();
    }
}
