using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace End_Of_Course_Exam
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ComplicatedPage complicatedPage = new ComplicatedPage();
            Console.WriteLine(complicatedPage.PageName);
            Assert.AreEqual("Complicated Page", complicatedPage.PageName);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SectionOfRandomStuff sectionOfRandomStuff = new SectionOfRandomStuff();
            sectionOfRandomStuff.FillForm();
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void TestMethod3()
        {
            SectionOfButtons sectionOfButtons = new SectionOfButtons();
            
            sectionOfButtons.Button.Click();
            Console.WriteLine("Null reference to button element");

        }
    }
}
