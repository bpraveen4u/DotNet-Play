
namespace MultiFrameworkLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var f = new Framework();
            var res = f.GetFramework();
#if NET8_0
            Assert.AreEqual("NET8", res);
#elif NET6_0
            Assert.AreEqual("NET6_OR_Greater", res);
#endif
        }
    }
}