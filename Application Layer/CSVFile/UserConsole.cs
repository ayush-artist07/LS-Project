using System;
using System.IO;
using Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile
{
    public class UserConsole
    {
        /// <summary>
        ///Consist of console which guides users and calls 
        ///the required methods for the functionalities
        /// </summary>
        public static void Welcome()
        {
            //boolean property helps to know wether user wants to conitnue with application or exit
            bool DoRunApplicationAgain = true;

            while (DoRunApplicationAgain == true)
            {
                try
                {
                    Constant.WelcomeUser(); //This brings the Welcome Screen with all the available options.

                    int OptionSelectedByUser = int.Parse(Console.ReadLine());//User can select one of the available choice's
                    switch (OptionSelectedByUser)
                    {
                        case 1:// Add a new Record to the database
                            {
                                Write UpdateRecord = new Write();
                                UpdateRecord.InFile();
                            }
                            break;
                        case 2://Get Students Record sorted by entry time in database
                            {
                                Arrange.ByOrderOfEntry();
                            }
                            break;
                        case 3://Get Students Record sorted by name than by percentage
                            {
                                Arrange.ByNameThanByPercentage();
                            }
                            break;
                        case 4://Find's Failed Students record from the database
                            {
                                Failed.Students();
                            }
                            break;
                        case 5:// Search a particular keyword student details
                            {
                                Console.WriteLine(Constant.GetSearchName);
                                string Name = Console.ReadLine();
                                Search.ByName(Name);
                            }
                            break;
                        case 6:// Find's students with particular Grades
                            {
                                Grades GetGrades = new Database.Grades();
                                GetGrades.OfStudent();
                                GetGrades.Print();
                            }
                            break;
                        case 7://Stops user from further execution of the program
                            {
                                DoRunApplicationAgain = false;
                            }
                            break;
                        default://If user selects other than above given choices
                            {
                                Console.WriteLine(Constant.DefaultChoice);
                            }
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

