using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarningsTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Warningss()
        {
            int total = 100, m1 = 60, m2 = 75;
            string name = null;
            Warn.If(m1 > 100);
            Warn.If(m2< 100);
            Warn.If(name == null);
            Warn.Unless(total > 200);
            Assert.Warn("This is warning message");
        }
    }
}
