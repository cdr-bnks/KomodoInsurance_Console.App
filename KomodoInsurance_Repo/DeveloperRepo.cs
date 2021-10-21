using KomodoInsuranceConsole.App;
using System.Collections.Generic;
using System;
using System.Linq;
using KomodoInsurance.Library;

namespace KomodoInsurance_Repo
{
    //   They should be able to see a list of existing developers to choose from and add to existing teams.
    //   

    //Challenge: Our HR Department uses the software monthly to get a list of all our Developers that need a Pluralsight license. Create this functionality in the Console Application

    //Challenge: Some of our managers are nitpicky and would like the functionality to add multiple Developers to a team at once, rather than one by one.Integrate this into your application.

    // CRITERIA
    //1) Solution Structure

    //2) Fuctional Code: Project Compiles/ Runs 

    //3)Repo - This includes creation and Implementation of all CRUD Methods DevRepo & DevTeamRepo

    //4)Console App Functionality for the UI portion Runs - Business logic UI makes sense. - Users do not know the innerworkings of the app: Create fields

    //5) No extra white space as well as maintained appropriate naming conventions.

    //6) [Challenges] implemented in project. CLEAN, MODULAR. UI is clean and very User friendly. EX.
    // ----------------------------------------------------------------------------------------------------------------------------  
    //Single-responsibility
    //Open-closed
    //Liskov substitution
    //Interface segregation
    //Dependency inversion
    public class DeveloperRepo
    {
         readonly Dictionary<int, Developer> _developerDictionary = new Dictionary<int, Developer>();
        
        public bool AddDeveloperToDirectory(Developer developer)
        {
            int developerNum = _developerDictionary.Count;
            _developerDictionary.Add(developerNum, developer);
            bool developerAdded = _developerDictionary.Count > developerNum ? true : false;
            return developerAdded;
        }
        
        public Dictionary<int, Developer> GetEachDeveloper() 
        {
            return _developerDictionary;
         }

        public bool GetDeveloperAccessCode(Developer access)
        {
            int idLog = _developerDictionary.Count;
            _developerDictionary.Add(idLog, access);
            bool idAdded = _developerDictionary.Count > idLog ? true : false;
            return idAdded;

        }
        public Developer GetDeveloperByName(string name)
        {
            foreach(KeyValuePair<int, Developer>  in _developerDictionary)
        }
        public bool UpdateDeveloperDirectory(string outOfDateLog, Developer upDatedLog)
        {
            Developer outDated =
        }


                



                
            
        

         

        

        
    }
  
}
