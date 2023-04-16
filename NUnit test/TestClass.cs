using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_test
{
    public class TestClass
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number > 3 && (number % 2 == 0 || number % 3 == 0))
                return false;

            for (int i = 5; i < Math.Sqrt(number); i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}
