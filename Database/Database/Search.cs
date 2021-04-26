using System;
using System.Collections.Generic;
using Exceptions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Search
    {
        private static List<ApplicantsInfo> _allStrings = new List<ApplicantsInfo>();
        private static List<ApplicantsInfo> _substringPresent = new List<ApplicantsInfo>();

        /// <summary>
        /// Search particular substring present in the Full Name
        /// if present returns all such Names with their details
        /// </summary>
        /// <param name="name">Takes user input name that user wants to search</param>
        public static void ByName(string name)
        {
            Read GetAllRecords = new Read();
            _allStrings = GetAllRecords.FromFile(); //Fetch all the records from the database

            _substringPresent.Clear();//Clear all the previous records present in the List

            //Checks if particular substring is present in any part of the name
            foreach (var x in _allStrings)
            {
                if (x.Name.Contains(name))
                {
                    _substringPresent.Add(x);   
                }
            }

            //If Substring is present in any Name than we print each Students details one by one
            if(_substringPresent.Count>0)
            {
                _substringPresent.ForEach(x => Console.WriteLine($"{x.Name} {x.Age} {x.Percentage}"));
                
            }
            //if no such string is present give a message for the same
            else if(_substringPresent.Count==0)
            {
                Console.WriteLine(Constant.NoMatchFound);
            }
            else
            {
                throw new NoItemPresentInTheFileException();
            }
        }
    }
}
