using KomodoInsurance.Library;
using System.Collections.Generic;

namespace KomodoInsurance_Repo
{
    public class DeveloperRepo
    {
         protected readonly Dictionary<int, Developer> _developerDirectory = new Dictionary<int, Developer>();

        public bool AddDeveloperToDirectory(Developer developer)
        {
            int developerNum = _developerDirectory.Count;
            _developerDirectory.Add(developerNum, developer);
            bool developerAdded = _developerDirectory.Count > developerNum ? true : false;
            return developerAdded;
        }

        public Dictionary<int, Developer> GetEachDeveloper()
        {
            return _developerDirectory;
        }

        public bool GetDeveloperAccessCode(Developer access)
        {
            int idLog = _developerDirectory.Count;
            _developerDirectory.Add(idLog, access);
            bool idAdded = _developerDirectory.Count > idLog ? true : false;
            return idAdded;

        }
        public Developer GetDeveloperByName(string name)
        {
            foreach (KeyValuePair<int, Developer> kvp in _developerDirectory)
            {
                Developer developer = kvp;
                if (kvp.Value.Name.ToUpper() == name.ToUpper())
                {
                    return developer;

                }

            }
            return null;
        }
         

        public bool UpdateDeveloperDirectory( Developer upDateDeveloper, string devloperToUpdate)
        {
            Developer errorEmpLog = GetDeveloperByName(devloperToUpdate);
            if (_developerDirectory.ContainsKey(errorEmpLog.ID))
            {
                errorEmpLog.ID = upDateDeveloper.ID;
                errorEmpLog.Name = upDateDeveloper.Name;
                errorEmpLog.PSAccess = upDateDeveloper.PSAccess;
                errorEmpLog.Salary = upDateDeveloper.Salary;
                errorEmpLog.AccessCode = upDateDeveloper.AccessCode;

                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool RemoveExistingDeveloper(Developer existingDev)
        {
            bool devRemoved = _developerDirectory.Remove(existingDev.ID);
            return devRemoved;
        }
      
    }          
 }
