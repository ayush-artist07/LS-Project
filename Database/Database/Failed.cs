using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Failed
    {
        /// <summary>
        /// Reads the Database and finds the students below 60% and adds them to the failed Students 
        /// list and displays there entire details i.e Name,Age,Percentage
        /// </summary>
        public static void Students()
        {
            Read ReadDatabase = new Read();  
            List<ApplicantsInfo> InformationAllStudents=ReadDatabase.FromFile();
            List<ApplicantsInfo> InformatioFailedstudents = new List<ApplicantsInfo>();

            foreach(var x in InformationAllStudents)
            {
                if(x.Percentage<60)
                {
                    ApplicantsInfo NewfailedStudent = new ApplicantsInfo(x.Age, x.Name, x.Percentage);
                    InformatioFailedstudents.Add(NewfailedStudent);
                }
            }
            
            InformatioFailedstudents.ForEach(x => Console.WriteLine($"{x.Name} {x.Age} {x.Percentage}"));
        }
    }
}
