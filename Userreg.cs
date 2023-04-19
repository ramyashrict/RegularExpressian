using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressian
{
        public class validation
        {
            public static string FirstName = "^[A-Z]{1}[a-z]{3}$";

            public static bool Check(string name)
            {
                return Regex.IsMatch(name, FirstName);
            }
        }
    }
}
