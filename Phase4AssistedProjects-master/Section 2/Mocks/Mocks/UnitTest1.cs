using Moq;

namespace Mocks
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Mocking()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockcalc = new Mock<ICalculator>();
            ICalculator calc = mockcalc.Object;
            Assert.That(calc, Is.Not.Null);
        }
    }
}