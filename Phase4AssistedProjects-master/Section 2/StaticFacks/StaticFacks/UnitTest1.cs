namespace StaticFacks
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void StaticFack()
        {
            int x = 10, y = 20;
            var wrapper = new SCalcWrapper();
            Assert.That(wrapper.add(x,y), Is.EqualTo(x+y));
        }
    }
}