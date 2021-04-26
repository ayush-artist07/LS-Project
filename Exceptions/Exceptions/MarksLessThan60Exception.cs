using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MarksLessThan60Exception : Exception
    {
        public MarksLessThan60Exception()
             {

            }
    /// <summary>
    /// Students having percentage less than 60 are given the warning
    /// about their low percentages by throwing this exception
    /// </summary>
    /// <param name="percentage"></param>
    public MarksLessThan60Exception(double percentage)
            : base(String.Format($"This student is fail -{percentage}"))
        {

    }
}
}
