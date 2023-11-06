using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace exam_loan_program
{
    [TestClass]
    public class LoanTest
    {
        [TestMethod]
        public void TestHomeLoan()
        {
            HomeLoan hauseLoan = new HomeLoan(
                "00001",
                "Bob",
                "Rock",
                3.5M,
                210_000,
                30,
                "Branilaca grada 5",
                "2022",
                "500"
                );
            Console.WriteLine(hauseLoan);
            Assert.AreEqual(3010M, hauseLoan.CalculateInterest());
        }


        [TestMethod]
        public void TestAutoLoan()
        {
            AutoLoan autoLoan = new AutoLoan(
                "00002",
                "Bob",
                "Rock",
                7.5M,
                12_000M,
                4,
                "2022",
                "Cross x",
                "Toyota",
                "gold"
                );
            Console.WriteLine(autoLoan);
            Assert.AreEqual(2925M, autoLoan.CalculateInterest());
        }
    }
}
