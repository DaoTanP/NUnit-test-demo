using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_test
{
    class StringUtils
    {
        public static string ReverseString(string s)
        {
            if (s.Length <= 1)
                return s;

            char[] a = s.ToArray().Reverse().ToArray();
            string r = string.Join("", a);
            return r;
        }
    }
}
