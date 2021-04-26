using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
 /// The exception is thrown when database has no data to look for
 /// </summary>
    public class NoItemPresentInTheFileException : Exception
    {
        public NoItemPresentInTheFileException()
            : base(String.Format("No data is Present in the database- "))
        {

        }
    }
}
