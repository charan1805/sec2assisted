using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void MultipleAssertionss()
        {
            int total = 100, m1 = 60, m2 = 75;
            string name = null;
            Assert.Multiple(() =>
            {
                Assert.That(m1, Is.Not.EqualTo(m2));
                Assert.That(m1, Is.LessThan(m2));
                Assert.That(m2, Is.InRange(50, 75));
            });
        }
    }
}
