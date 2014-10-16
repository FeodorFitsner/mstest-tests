using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CategorizedUnitTests
    {
        [TestMethod, TestCategory("A")]
        public void Test_from_category_A()
        {
            var a = 3;
            Assert.AreEqual(3, a);
        }

        [TestMethod, TestCategory("B")]
        public void Test_from_category_B()
        {
            var b = 3;
            Assert.AreEqual(3, b);
        }

        [TestMethod, TestCategory("C")]
        public void Test_from_category_C()
        {
            var c = 3;
            Assert.AreEqual(3, c);
        }
    }
}
