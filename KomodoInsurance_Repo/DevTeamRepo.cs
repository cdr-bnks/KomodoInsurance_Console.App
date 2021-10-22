using KomodoInsurance.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KomodoInsurance.Library.DevTeam;

namespace KomodoInsurance_Repo
{
    class DevTeamRepo
    {
        protected readonly Dictionary<int, DevTeam> _devTeamDirectory = new Dictionary<int, DevTeam>();

        protected readonly List<Team> _teamDirectory = new List<Team>();
        public bool AddDeveloperTeamToDirectory(Team devTeam)
        {
            int developerNum = _teamDirectory.Count;
            _teamDirectory.Add(devTeam);
            bool developerAdded = _teamDirectory.Count > developerNum ? true : false;
            return developerAdded;
        }

        public Dictionary<int, DevTeam> GetEachDeveloperTeam()
        {
            return _devTeamDirectory;
        }

        public bool GetAllDeveloperTeamAccessCode(DevTeam access)
        {
            int idLog = _devTeamDirectory.Count;
            _devTeamDirectory.Add(idLog, access);
            bool idAdded = _devTeamDirectory.Count > idLog ? true : false;
            return idAdded;

        }
        public Team GetManagersByName(string name)
        {
            foreach (Team Manager in _teamDirectory)
            {
                
                if (Manager.ManagerNames.ToUpper() == name.ToUpper())
                {
                    return Manager;

                }

            }
            return null;
        }


        public bool UpdateTeamDeveloperDirectory (Team upDateTeam, string teamToUpdate)
        {
             
            Team errorEmpLog = GetManagersByName(teamToUpdate);
            if (_teamDirectory.Contains(errorEmpLog))
            {
                errorEmpLog.ID = upDateTeam.ID;
                errorEmpLog.Name = upDateTeam.Name;
                errorEmpLog.Salary = upDateTeam.Salary;
                errorEmpLog.ManagerList = upDateTeam.ManagerList;

                return false;
            }
            else
            {
                return true;
            }

        }
        public bool RemoveExistingDeveloper(DevTeam existingDev)
        {
            bool teamRemoved = _devTeamDirectory.Remove(existingDev.ID);
            return teamRemoved;
        }
    }
}
