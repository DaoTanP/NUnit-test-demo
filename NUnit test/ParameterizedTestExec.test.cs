using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace NUnit_test
{
    class ParameterizedTestExec
    {
        /*[Test, Sequential]
        public void IsPrimeTest(
            [Values(2, 102, 0, -129)] int n,
            [Values(true, false, false, false)] bool eo)
        {
            bool result = TestClass.IsPrime(n);

            Assert.That(result, Is.EqualTo(eo));
        }*/

        [TestCaseSource("GetPrimeNumberTestData")]
        public void IsPrimeTest(int n, bool eo)
        {
            bool result = TestClass.IsPrime(n);

            Assert.That(result, Is.EqualTo(eo));
        }

        public static IEnumerable<object[]> GetPrimeNumberTestData()
        {
            // Lấy đường dẫn của file csv chứa dữ liệu test
            string filePath = Path.GetFullPath(@"..\..\..\primeNumber-test_data.csv");

            // Khởi tạo reader đọc file
            StreamReader reader = new StreamReader(filePath);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            // Đọc từng dòng trong file
            while (csv.Read())
            {
                int number = int.Parse(csv[0]);
                bool expectedOutcome = bool.Parse(csv[1]);
                yield return new object[] { number, expectedOutcome };
            }
        }
        [TestCaseSource("GetReverseStringTestData")]
        public void ReverseStringTest(string s, string eo)
        {
            string result = StringUtils.ReverseString(s);

            Assert.That(result, Is.EqualTo(eo));
        }


        public static IEnumerable<string[]> GetReverseStringTestData()
        {
            // Lấy đường dẫn của file csv chứa dữ liệu test
            string filePath = Path.GetFullPath(@"..\..\..\reverseString-test_data.csv");

            // Khởi tạo reader đọc file
            StreamReader reader = new StreamReader(filePath);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            // Đọc từng dòng trong file
            while (csv.Read())
            {
                string s = csv[0];
                string expectedOutcome = csv[1];
                yield return new string[] { s, expectedOutcome };
            }
        }
    }
}
