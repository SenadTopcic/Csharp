using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EndOfSectionExam_ResaleValue
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ItemPrice apple = new ItemPrice(12.99);

            Console.WriteLine(apple);
        }
    }
}
