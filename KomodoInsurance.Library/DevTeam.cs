using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Library
{
    public class DevTeam : Developer
    {
        public override void DataLog()
        {
            base.DataLog();
        }
        public enum ListOfManagers
        {
            Carlos = 1,
            Tyler,
            Ruby,
            Hanma

        }

        public DevTeam(int id, string name, double salary, bool devAccess, int aid, List<Team> teams)
            : base(id, name, salary, devAccess, aid )
        {
            Teams = teams;
            
        }
        public List<Team> Teams { get; set; }
        public class Team : Employee
        {
            public override void DataLog()
            {
                base.DataLog();
            }
            public string ManagerNames
            { get; }
            public ListOfManagers ManagerList { get; set; }

            public Team(int id, string name, double salary, string managerNames, ListOfManagers managerList)
               : base(id, name, salary)
            {
                ManagerNames = managerNames;
                ManagerList = managerList;
            }
        }
       
        

        
        
    }
}
