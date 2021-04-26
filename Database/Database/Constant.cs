using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    /// <summary>
    /// Stores the path for the CSV file to be updated.
    /// Contains all the messages to be displayed.
    /// </summary>
    public static class Constant
    {
        public const string ReadWriteFilePath = @"C:\test.csv";
        public const string Details = "Please Enter the below details as specified";
        public const string DefaultChoice = "Your enterd choice is out of given choice try again. \n";
        public const string GetName = "Enter Student's Name";
        public const string GetAge = "Enter Student's Age";
        public const string GetPercentage = "Enter Student's Percentage";
        public const string GetSearchName = "Enter the Name you want to Search";
        public const string NoMatchFound = "No Match Found for the given Input";
        public const string GradesUserWants = "Please Enter which grade student you want A,B,C,D";

        /// <summary>
        /// Message to guide through to the user what he wants to do
        /// </summary>
        public static void WelcomeUser()
        {
            Console.WriteLine("\t\t\t\tWelcome to the University Record Portal\n\nSelect your desired choice from the below-");
            Console.WriteLine("1. Enter new Record");
            Console.WriteLine("2. Get Student Record Order By Entry time");
            Console.WriteLine("3. Get Student Record Order by Name than by Percentage");
            Console.WriteLine("4. Get Failed student List");
            Console.WriteLine("5. Search Student's By Name KeyWords");
            Console.WriteLine("6. Get Student By Grades");
            Console.WriteLine("7. Exit");
        }
        
    }
}
