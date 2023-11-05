using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace exam_List_Cleaner
{



    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add("13.5");
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

            ArrayList cleanList = Lists_Cleaner.Clean_strings(dataList);
            decimal number = Lists_Cleaner.SumOfAllElements(cleanList);
            Console.WriteLine(number);
            Assert.AreEqual(147, number );

        }
    }
}
