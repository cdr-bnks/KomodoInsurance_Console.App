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
                         AddDeveloperToDirectory();
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
        
        private static void AddDeveloperToDirectory()
        {
            

            Developer developerOne = new Developer(1, "Jackie", 88000, true, 1331);
           Developer developerTwo = new Developer(2, "Gustav", 90000, false, 2820);
            //Developer developerThree = new Developer(3, "Yojiro", 80000, true, 3330);
            //Developer developerFour = new Developer(4, "Baki", 62000, true, 3590);
            //Developer developerFive = new Developer(5, "Ali", 89000, true, 1679);
            //Developer developerSix = new Developer(6, "Ryu", 99000, false, 8550);
            //Developer developerSeven = new Developer(7, "Nola", 100000, true, 1660);
            //Developer developerEight = new Developer(8, "Susie", 77000, true, 7256);
            //Developer developerNine = new Developer(9, "Jacob", 95000, true, 0984);
            //Developer developerTen = new Developer(10, "Caleb", 85000, false, 2890);
            //Developer developerEleven = new Developer(11, "Drew", 75000, true, 4730);
            //Developer developerTwelve = new Developer(12, "Lola", 55000, false, 1209);

            //developerDicitonary.Add(developerOne.ID, developerOne);
            //developerDicitonary.Add(developerTwo.ID, developerTwo);
            //developerDicitonary.Add(developerThree.ID, developerThree);
            //developerDicitonary.Add(developerFour.ID, developerFour);
            //developerDicitonary.Add(developerFive.ID, developerFive);
            //developerDicitonary.Add(developerSix.ID, developerSix);
            //developerDicitonary.Add(developerSeven.ID, developerSeven);
            //developerDicitonary.Add(developerEight.ID, developerEight);
            //developerDicitonary.Add(developerNine.ID, developerNine);
            //developerDicitonary.Add(developerTen.ID, developerTen);
            //developerDicitonary.Add(developerEleven.ID, developerEleven);
            //developerDicitonary.Add(developerTwelve.ID, developerTwelve);
        }
    }
}
