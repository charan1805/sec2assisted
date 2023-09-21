using Moq;
using static MoksStubsFakes.Calculator;

namespace MoksStubsFakes
{
    [TestFixture]
    public class Tests
    {
       [Test]
       public void Mocking()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockcalc = new Mock<ICalculator>();
            ICalculator calc=mockcalc.Object;
            Assert.That(calc, Is.Not.Null);
        }
        [Test]
        public void stub()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockcalc=new Mock<ICalculator>();
            mockcalc.Setup(c => c.add(It.IsAny<Int32>(), It.IsAny<Int32>())).Returns(x + y);
            ICalculator calc= mockcalc.Object;
            Assert.That(calc.add(x,y),Is.EqualTo(x + y));


        }
        [Test]
        public void Fack()
        {
            int x = 9, y = 19;
            FackCalcultor calc= new FackCalcultor();
            Assert.That(calc.add(x,y), Is.GreaterThan(x + y));
        }
    }
}