using System;
using System.Collections.Generic;
using System.Linq;
using Exceptions;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Arrange
    {
        private static List<ApplicantsInfo> UnsortedList = new List<ApplicantsInfo>();

        /// <summary>
        /// Sorts the entire students database
        /// first the basis of Name and if 2 students are having
        /// same Name than by Percentage
        /// </summary>
        public static void ByNameThanByPercentage()
        {
            Read GetAllRecords = new Read();
            UnsortedList=GetAllRecords.FromFile();
           
            List<ApplicantsInfo> SortedList = UnsortedList.OrderBy(x => x.Name)
                                       .ThenBy(x => x.Percentage)
                                       .ToList();

            if(SortedList.Count>0)
            {
                SortedList.ForEach(x => Console.WriteLine($"{x.Name} {x.Age} {x.Percentage}"));
            }
            else
            {
                throw new Exceptions.NoItemPresentInTheFileException();
            }
        }
        /// <summary>
        /// Display's the data in the database according to the time data was entered
        /// </summary>
        public static void ByOrderOfEntry()
        {
            List<ApplicantsInfo> Ordered = new List<ApplicantsInfo>();

            Read GetAllRecords = new Read();
            Ordered = GetAllRecords.FromFile();

            Ordered.ForEach(x => Console.WriteLine($"{x.Name} {x.Age} {x.Percentage}"));

        }
    }
}
