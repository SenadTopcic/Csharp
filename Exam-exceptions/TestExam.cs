using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exam_exceptions
{
    [TestClass]
    public class TestExam
    {
        //Create a try/catch block in each test that calls the method and catches the
        //specific exception that is produced.  Each method should be handled so that if an 
        //exception occurs, the test will still pass.
        //write out the error message that occurs so you can view it in the output

        [TestMethod]
        public void Test_Weekly_Wages()
        {
            try 
            {
                ExamHelper.WeeklyWages();

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Out of range");
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Test_Calc_Result()
        {
            try { ExamHelper.CalculateResult(); }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
        }

        [TestMethod]
        public void Test_Number_Check()
        {
            try { ExamHelper.NumberCheck(); } catch (DivideByZeroException ex) { Console.WriteLine(ex.Message); }
        }
    }
}