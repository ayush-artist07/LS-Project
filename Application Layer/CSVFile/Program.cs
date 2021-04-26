using System;
using Exceptions;
using CSVFile;
using System.IO;
using Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class Program
    {
        /// <summary>
        ///Main method consist of console which guides users and calls 
        ///the required methods with their functionalities
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            UserConsole.Welcome(); 
         }
      }
}

