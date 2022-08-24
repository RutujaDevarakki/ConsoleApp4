namespace TestProject1
{
    [TestClass]
    public class TestProjectDiv
    {
        [TestMethod]
        public void TestMethod1()
        {
            int divd = 100;
            int divisor = 5;
            int res;
            int expectedResult = 20;
            ConsoleApp4.div.Divide(divd, divisor, out res);
            Assert.AreEqual(expectedResult, res);


        }
    }
}
