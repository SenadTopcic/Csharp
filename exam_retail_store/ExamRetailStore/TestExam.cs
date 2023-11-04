using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace ExamRetailStore
{
    [TestClass]
    public class TestExam
    {
        [TestMethod]
        public void TestReceiptNumber()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    10,
                    2
                );
            Assert.IsTrue(rec1.ReceiptNumber > 0);
        }

        [TestMethod]
        public void TestReceiptNumberInvalidInput()
        {
            Receipt rec1 = new Receipt
                (
                    -12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    10,
                    2
                );
            Console.WriteLine( rec1.ReceiptNumber );
            Assert.AreEqual(1, rec1.ReceiptNumber);
        }

        [TestMethod]
        public void TestCustomerNumber()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    10,
                    2
                );
            Assert.IsTrue(rec1.CustomerNumber > 0);
        }

        [TestMethod]
        public void TestCustomerNumberInvalid()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    -6661,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    10,
                    2
                );
            Assert.AreEqual(1, rec1.CustomerNumber);
        }

        [TestMethod]
        public void TestItemNumber()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    10,
                    2
                );
            Assert.IsTrue(rec1.ItemNumber > 0 && rec1.ItemNumber < 9999);
        }

        [TestMethod]
        public void TestItemNumberInvalid()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    222223,
                    "Cevapi 10",
                    10,
                    2
                );
            Assert.AreEqual(1, rec1.ItemNumber );
        }

        [TestMethod]
        public void TestUniPrice()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    10,
                    2
                );
            Assert.IsTrue(rec1.UnitPrice > 0 && rec1.UnitPrice < 9999);
        }

        [TestMethod]
        public void TestUniPriceInvalid()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    -10,
                    2
                );
            Assert.AreEqual(1, rec1.UnitPrice );
        }

        [TestMethod]
        public void TestQuantityPurchase()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    10,
                    2
                );
          
            Console.WriteLine(rec1 );
            Assert.IsTrue(rec1.QuantityPurchased > 0);
        }

        [TestMethod]
        public void TestQuantityPurchaseInvalid()
        {
            Receipt rec1 = new Receipt
                (
                    12,
                    1,
                    "Himzo Polovina",
                    "Mostar",
                    "442 234",
                    23,
                    "Cevapi 10",
                    10,
                    -2
                );

            Console.WriteLine(rec1);
            Assert.AreEqual(1, rec1.QuantityPurchased );
        }
    }
}
