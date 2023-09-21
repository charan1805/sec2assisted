using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangActAssert
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AAA()
        {
            var calc = new Calculator();
            var ans = calc.add(5, 19);
            Assert.That(ans, Is.EqualTo(24));
        }
    }
}
