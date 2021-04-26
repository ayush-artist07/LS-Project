using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Exceptions;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Read
    {
        private List<ApplicantsInfo> _informationOfAllStudents = new List<ApplicantsInfo>();
        /// <summary>
        /// Read the data from the CSV file and stores into a list
        /// </summary>
        /// <returns>The list of all the record present in the CSV file</returns>
        internal List<ApplicantsInfo> FromFile()
        {
            try
            {
                ApplicantsInfo StudentsRecord = new ApplicantsInfo();

                using (StreamReader GetApplicantsInfo = new StreamReader(Constant.ReadWriteFilePath))
                {
                    String[] getData = File.ReadAllLines(Constant.ReadWriteFilePath);
                    
                    foreach (String data in getData)
                    {
                        var simplifiedData = data.Split(',');

                        StudentsRecord.Name = simplifiedData[0];
                        StudentsRecord.Age = int.Parse(simplifiedData[1]);
                        StudentsRecord.Percentage = Double.Parse(simplifiedData[2]);

                        _informationOfAllStudents.Add(new ApplicantsInfo(StudentsRecord.Age, StudentsRecord.Name, StudentsRecord.Percentage));
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
                return _informationOfAllStudents;
            }
        /// <summary>
        /// Prints the data of the CSV file
        /// </summary>
        public void PrintData()
        {
            _informationOfAllStudents.ForEach(x => Console.WriteLine($"{x.Name} {x.Age} {x.Percentage}"));
        }
       
        
    }
}
