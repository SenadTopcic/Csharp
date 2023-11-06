using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Final_Project_Housing_Application
{
    [TestClass]
    public class TestHousing
    {
        [TestMethod]
        public void TestSingleFamily()
        {
            SingleFamily family1 = new SingleFamily(500M, 100M, 5, 3, false,false, "Vienna", "Wood", "2001");
            SingleFamily family2 = new SingleFamily(1500M, 200M, 10, 3, true, false, "Vienna", "rock", "2002");
            SingleFamily family3 = new SingleFamily(2500M, 300M, 10, 4, false, true, "Vienna", "concreet", "2011");
            SingleFamily family4 = new SingleFamily(3500M, 400M, 12, 6, true, false, "Vienna", "bio", "2013");
            SingleFamily family5 = new SingleFamily(4500M, 500M, 16, 5, true, true, "Vienna", "Wood-Alu", "2021");

            List<SingleFamily> singleFamilies = new List<SingleFamily>();
            singleFamilies.Add(family1);
            singleFamilies.Add(family2);
            singleFamilies.Add(family3);
            singleFamilies.Add(family4);
            singleFamilies.Add(family5);

            foreach (SingleFamily family in singleFamilies)
            {
                Console.WriteLine(family);
            }
        }

        [TestMethod]
        public void TestMultiUnits()
        {
            MultiUnit unit1 = new MultiUnit("Flat", 4, 1200, "Wien", "brick", "2000");
            MultiUnit unit2 = new MultiUnit("Garsoniere", 4, 400, "Wien", "brick", "2020");
            MultiUnit unit3 = new MultiUnit("Apartman", 4, 1000, "Wien", "brick", "2002");
            MultiUnit unit4 = new MultiUnit("Studio", 4, 700, "Wien", "brick", "2020");
            MultiUnit unit5 = new MultiUnit("Tent", 4, 1200, "Wien", "brick", "2020");

            List<MultiUnit> units = new List<MultiUnit>();
            units.Add(unit1);
            units.Add(unit2);
            units.Add(unit3);
            units.Add(unit4);
            units.Add(unit5);

            foreach (MultiUnit unit in units)
            {
                Console.WriteLine(unit);
            }
        }

        [TestMethod]
        public void CombinedTest()
        {
            List<Housing> combinedList = new List<Housing>();

            combinedList.Add(new SingleFamily(500M, 100M, 5, 3, false, false, "Vienna", "Wood", "2001"));
            combinedList.Add(new SingleFamily(500M, 100M, 5, 3, false, false, "Vienna", "Wood", "2001"));
            combinedList.Add(new SingleFamily(500M, 100M, 5, 3, false, false, "Vienna", "Wood", "2001"));
            combinedList.Add(new SingleFamily(500M, 100M, 5, 3, false, false, "Vienna", "Wood", "2001"));
            combinedList.Add(new SingleFamily(500M, 100M, 5, 3, false, false, "Vienna", "Wood", "2001"));

            combinedList.Add(new MultiUnit("Garsoniere", 4, 400, "Wien", "brick", "2020"));
            combinedList.Add(new MultiUnit("Garsoniere", 4, 400, "Wien", "brick", "2020"));
            combinedList.Add(new MultiUnit("Garsoniere", 4, 400, "Wien", "brick", "2020"));
            combinedList.Add(new MultiUnit("Garsoniere", 4, 400, "Wien", "brick", "2020"));
            combinedList.Add(new MultiUnit("Garsoniere", 4, 400, "Wien", "brick", "2020"));

            foreach (Housing home in combinedList)
            {
                Console.WriteLine("Address: " + home.Address);
                Console.WriteLine("Projected Rent: " + home.ProjectedRentalAmt().ToString("C"));
            }
        }


    }
}
