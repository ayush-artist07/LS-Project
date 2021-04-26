using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
   public class Grades
    {
        private static List<ApplicantsInfo> GetPercentage = new List<ApplicantsInfo>();
        private static List<ApplicantsInfo> GetStudentsWithRequiredGrades = new List<ApplicantsInfo>();
        /// <summary>
        /// Evaluates and find the students having the required grades as asked
        /// by the user and stores it into a list
        /// </summary>
        public void OfStudent()
        {
            Console.WriteLine(Constant.GradesUserWants);
            char GradeUserWants='0';
            try
            {
                GradeUserWants = Convert.ToChar(Console.ReadLine()); //User enter's his her preferred choice
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Read GetAllrecords = new Read();
            GetPercentage = GetAllrecords.FromFile();

            if (GradeUserWants == 'A' || GradeUserWants == 'a')
            {
                foreach(var x in GetPercentage)
                {
                    if (x.Percentage > 90 && x.Percentage <= 100)
                    {
                        GetStudentsWithRequiredGrades.Add(x);
                    }
                }
            }
            else if (GradeUserWants == 'B' || GradeUserWants == 'b')
            {
                foreach (var x in GetPercentage)
                {
                    if (x.Percentage > 80 && x.Percentage <= 90)
                    {
                        GetStudentsWithRequiredGrades.Add(x);
                    }
                }
            }
            else if (GradeUserWants == 'C' || GradeUserWants == 'c')
            {
                foreach (var x in GetPercentage)
                {
                    if (x.Percentage > 70 && x.Percentage <= 80)
                    {
                        GetStudentsWithRequiredGrades.Add(x);
                    }
                }
            }
            else if (GradeUserWants == 'D' || GradeUserWants == 'd')
            {
                foreach (var x in GetPercentage)
                {
                    if (x.Percentage > 60 && x.Percentage <= 70)
                    {
                        GetStudentsWithRequiredGrades.Add(x);
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
         }
        /// <summary>
        /// Display's the required grades as asked by the user
        /// </summary>
        public void Print()
        {
            if (GetStudentsWithRequiredGrades.Count > 0)
            {
                GetStudentsWithRequiredGrades.ForEach(x => Console.WriteLine($"{x.Name} {x.Age} {x.Percentage}"));
            }
            else
            {
                throw new Exceptions.NoItemPresentInTheFileException();
            }
            GetStudentsWithRequiredGrades.Clear();
        }
     }
}


