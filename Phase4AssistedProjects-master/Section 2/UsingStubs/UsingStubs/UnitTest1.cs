using Moq;

namespace UsingStubs
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Stub()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockCalc = new Mock<ICalculator>();
            mockCalc.Setup(c => c.add(It.IsAny<Int32>(), It.IsAny<Int32>())).Returns(x + y);
            ICalculator calc=mockCalc.Object;
            Assert.That(calc.add(x, y), Is.EqualTo(x + y));
        }
    }
}