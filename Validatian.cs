using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressian
{
        public class validation
        {
            public static string FirstName = "^[A-Z]{1}[a-z]{3}$";
            public static string LastName = "^[A-Z]{1}[a-z]{3}$";
            public static bool Check(string name)
            {
                return Regex.IsMatch(name, FirstName);
            }
            public static bool Check2(string name1)
            {
                return Regex.IsMatch(name1, LastName);
            }
        }
    }
  
