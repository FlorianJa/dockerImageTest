namespace Lib.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ShouldWork()
        {
            Assert.IsTrue(true, "This test should always pass.");
        }

        [TestMethod]
        public void Return42()
        {
            var c = new Class1();
            Assert.AreEqual(42, c.foo(), "The foo method should return 42.");
        }
    }
}
