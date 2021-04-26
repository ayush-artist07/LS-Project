using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Database
{
    public class Check
    {
        /// <summary>
        /// Verify's whether the name entered by the user is Valid or not
        /// </summary>
        /// <param name="name">User Entered Name</param>
        /// <returns></returns>
        public static bool IsValidName(string name)
        {
            if (!((name[0] >= 'a' && name[0] <= 'z') || (name[0] >= 'A' && name[0] <= 'Z')))
            {
                return false;
            }

            for (int i = 1; i < name.Length; i++)
            {
                if (!((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= '0' && name[i] <= '9') || name[i] == '_' || name[i] == ' '))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
