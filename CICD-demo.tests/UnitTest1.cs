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
            Assert.True(1 == 0);
        }
    }
}