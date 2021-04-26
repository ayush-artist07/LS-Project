using System;
using System.IO;
using Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Write
    {
        /// <summary>
        /// Write In CSV File or Append the new records in the CSV file
        /// </summary>
        public void InFile()
        {
            Console.WriteLine(Constant.Details);

            Console.WriteLine(Constant.GetName);
            string Name=Console.ReadLine(); //Get Name from the user

            if(Check.IsValidName(Name)==false)
            {
                throw new InvalidDataException(); //Verify wether the name is valid or not
            }

            Console.WriteLine(Constant.GetAge);
            int Age = int.Parse(Console.ReadLine());//takes age as input from the user

            if(Age<18 || Age>30)
            {
                throw new AgeOutOfRangeException(Age); //Verify if age is valid one
            }

            Console.WriteLine(Constant.GetPercentage);
            double Percentage = Double.Parse(Console.ReadLine()); //takes precentage as input from the user

            using (StreamWriter SetApplicantsInfo = new StreamWriter(Constant.ReadWriteFilePath, true))
            {
                    ApplicantsInfo NewApplicant = new ApplicantsInfo(Age, Name, Percentage);

                    SetApplicantsInfo.WriteLine("{0},{1},{2}", NewApplicant.Name, NewApplicant.Age, NewApplicant.Percentage);
                
                    if(Percentage<60)
                     {
                        throw new MarksLessThan60Exception(Percentage); //if student is in failed list throws exceptioin
                     }
            }
        }
    }
}
