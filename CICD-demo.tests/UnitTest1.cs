using NUnit.Framework;

namespace CICD_demo.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Calc calc = new();
            Assert.AreEqual(3, calc.Add(1, 2));
        }
    }
}