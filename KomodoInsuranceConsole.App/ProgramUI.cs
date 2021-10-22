using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceConsole.App
{
    class ProgramUI 
    {
        //private readonly DeveloperRepo _developerRepo = new DeveloperRepo
        public void Run()
        {
            RunData();
        }

        public void RunData()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine(" Greetings and Salutation Board members and Managers of Komodo Insurance.\n" +
                    "I have exicuted the beta software application your team acquired of me.\n" +
                    "Here are all the different functionalities Product Managers can use to better aid them in their search for the right\n" +
                    "canidates.\n" +
                    "Enter in an option you would like to select.\n\n\n" +
                    "You can choose from:\n\n" +
                    "1.| Display the developer log or view teamlog ======> []\n\n" +
                    "2.| Search for the Team of developers by Access code ======>[]\n\n" +
                    "3.| Get the existing developer log by Name ======> []\n\n" +
                    "4.| Update the directory log and Team Log   ======> []\n\n" +
                    "5.| Exit =====>[]\n\n ");
                string userInterface = Console.ReadLine();
                switch (userInterface)
                {
                    case "1":
                        // AddDeveloperToDirectory();
                        break;
                    case "2":
                        //GetEachDeveloper();
                        break;
                    case "3":
                        //GetDeveloperAccessCode();
                        break;
                    case "4":
                        //RemoveFromExistingDeveloperLog();
                        break;
                    case "5":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number within the scope of 1-5.\n" +
                            "Press any key to continue ====>__");
                        Console.ReadKey();
                        break;
                } 
                

            }
           
            

            








        }








    }
}
