using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Split
    {
        public static void Name(string name)
        {
            var fullName = name.Split(' ');
            int numberOfPartsOfName=fullName.Count();

            string firstName = fullName[0];
            string lastName=null;
            StringBuilder middleName=new StringBuilder();

            if(numberOfPartsOfName>1)
            {
                lastName = fullName[numberOfPartsOfName - 1];
            }
            else if (numberOfPartsOfName <= 1)
            {
                lastName = "No last Name";
            }
            if (numberOfPartsOfName>2)
            {
                for(int i=1;i<(numberOfPartsOfName-1);i++)
                {
                      middleName.Append($"{fullName[i]} ");
                }
            }
            else
            {
                middleName.Append("No Middle Name");
            }
            
            

            Console.WriteLine(firstName);
            Console.WriteLine(middleName);
            Console.WriteLine(lastName);

        }
    }
}
