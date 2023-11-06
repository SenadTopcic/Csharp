using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace exam_section_interfaces
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual(pageObject1.PageName, "Page Name 1");
        }

        [TestMethod]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual(pageObject2.PageName, "Page Name 2");
        }
    }
}
