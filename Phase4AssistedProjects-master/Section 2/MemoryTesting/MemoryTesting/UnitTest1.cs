namespace MemoryTesting
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicAssertions()
        {
            int m1 = 60, m2 = 75;
            string name = null;
            Assert.That(m1, Is.Not.EqualTo(m2));
            Assert.That(m1, Is.LessThan(m2));
            Assert.That(m2, Is.InRange(50, 75));
            Assert.That(name, Is.Null);
        }
        [Test]
        public void Warningss()
        {
            int total = 100, m1 = 60, m2 = 75;
            string name = null;
            Warn.If(m1 > 100);
            Warn.If(m2 < 100);
            Warn.If(name == null);
            Warn.Unless(total > 200);
            Assert.Warn("This is warning message");
        }
        [Test]
        public void AAA()
        {
            var calc = new Calculator();
            var ans = calc.add(5, 19);
            Assert.That(ans, Is.EqualTo(24));
        }
        [Test]
        public void MultipleAssertionss()
        {
            int m1 = 60, m2 = 75;

            Assert.Multiple(() =>
            {
                Assert.That(m1, Is.Not.EqualTo(m2));
                Assert.That(m1, Is.LessThan(m2));
                Assert.That(m2, Is.InRange(50, 75));
            });
        }
        [Test]
        public void Exceptions()
        {
            var calc = new Calculator();
            Assert.Throws<InvalidOperationException>(() =>
            calc.addstrings("aaa", "bbb"));
        }
    }
}