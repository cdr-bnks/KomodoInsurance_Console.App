using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceConsole.App
{
    class ProgramUI 
    {
        private readonly DeveloperRepo _developerRepo = new DeveloperRepo
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
                    "developer/developer Teams.\n" +
                    "Enter in an option you would like to select.\n" +
                    "You can choose from:\n" +
                    "1.| Display The Employee(Developer) log ======> []\n" +
                    "2.| Search For The Developer by Access code ======>[]\n" +
                    "3.| Update existing Employee(Developer) log ======> []\n" +
                    "4.| Remove Employee(Developer) from existing log ======> []\n" +
                    "5.| Exit ======> []");
                string userInterface = Console.ReadLine();
                switch (userInterface)
                {
                    case "1":
                        // DisplayDeveloperLog();
                        break;
                    case "2":
                        //FindDeveloperByAccessCode();
                        break;
                    case "3":
                        //UpdateExistingDeveloperLog();
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
