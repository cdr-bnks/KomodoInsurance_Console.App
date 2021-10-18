using KomodoInsuranceConsole.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Repo
{ 
    // Developers Names and ID numbers.
  
    // Create a Dictionary<> for each Developer.
  
    // Do the Developers have access to the online learning tool: PLURALSIGHT? [Create readonly for the developers who have access]
  
    // Managers need to add and remove members to & from a team by their unique identifier.
  
    // Mangers should be able to see a list of existing developers to choose from and add to existing teams.
  
    // Managers will have their own team and add Developers indiviually from the Developer Directory to that team.
  // --------------------------------------------------------------------------------------------------------------------------
    //[Challenge]: HR Department uses the software *monthly* and gets a list of all the Developers that need PLURALSIGHT liscense. Create this functionality in the Console App.

    //[Challenge]: Some of our managers are nitpicky and would like the functionality to add multiple Developers to a team at once, rather than one by one. integraate this into the App.
  // ---------------------------------------------------------------------------------------------------------------------------
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

   public class DeveloperRepo : Developer
    {
       protected readonly Dictionary<int, Developer> _developerDictionary = new Dictionary<int, Developer>();

        _developerDictionary.Add(developerOne.ID, developerOne)
    }
}
