using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit_test
{
    public class TestExec
    {
        [Test]
        public void IsPrimeTest()
        {
            bool result = TestClass.IsPrime(5);

            Assert.IsTrue(result);
        }

        [Test]
        public void ReverseStringTest()
        {
            string r = StringUtils.ReverseString("live");
            Assert.That(r, Is.EqualTo("evil"));
        }
    }
}
