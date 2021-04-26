using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    //Age is not in the specified range the below exception is thrown
    public class AgeOutOfRangeException : Exception
    {
        public AgeOutOfRangeException()
        {

        }
        /// <summary>
        /// This exception is thrown explicitly whenever user enters 
        /// the age which is less than 18 or greater than 30
        /// </summary>
        /// <param name="age">This is the age given as input by the user</param>
        public AgeOutOfRangeException(int age)
            : base(String.Format("Invalid Age: {0}", age))
        {

        }

    }
}
