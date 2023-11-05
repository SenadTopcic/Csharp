using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace exam_Property_tax_calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Property senad = new Property("Bugojno bb", 100_000M, 115_000M);
            Console.WriteLine(senad);
            Assert.AreEqual(902.70M, senad.TaxesDue);
            Console.WriteLine($"Next year assessed value {senad.NextYearAssessedValue(),0:C}");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Property maida = new Property("Mutgasse 26 Vienn", 190_000M, 200_000M);
            Console.WriteLine(maida);
            Assert.AreEqual(1_755.25M, maida.TaxesDue);
            Console.WriteLine($"Next year assessed value {maida.NextYearAssessedValue(),0:C}");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Property taidahana = new Property("Karlsplatz", 150_000M, 160_000M);
            Console.WriteLine(taidahana);
            Assert.AreEqual(1_354.05M, taidahana.TaxesDue);
            Console.WriteLine($"Next year assessed value {taidahana.NextYearAssessedValue(),0:C}");
        }
        
    }
}
