using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace extensionMethods
{
    public static class StringExtension
    {
        public static string FirstChar(this string a)
        {
            try
            {
                return a[0].ToString();
            }
            catch
            {
                throw new ArgumentNullException();
            }

        }
    }
}
