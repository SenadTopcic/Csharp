using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Housing_Application
{
    internal class MultiUnit :Housing, IUnits
    {
        private string complexName;
        private int numberOfUnits;
        private decimal rentAmountPerUnit;

        public string ComplexName 
        { get { return complexName; } set { complexName = value; } }
        public int NumberOfUnits
        { get { return numberOfUnits; } set {  numberOfUnits = value; } }
        public decimal RentAmountPerUnit
        { get { return rentAmountPerUnit; } set {  rentAmountPerUnit = value; } }

        public MultiUnit(string _complexName, int _numberOfUnits, decimal _rentAmountPerUnit, string _address, string _typeOfConstruction, string _yearBuilt) : base(_address, _typeOfConstruction, _yearBuilt)
        {
            ComplexName = _complexName;
            NumberOfUnits = _numberOfUnits;
            RentAmountPerUnit = _rentAmountPerUnit;
        }

        public int GetNumUnits()
        {
            return numberOfUnits;
        }
        public override decimal ProjectedRentalAmt()
        {
            return rentAmountPerUnit*(decimal)(numberOfUnits*12);
        }
        public override string ToString()
        {
            return base.ToString() +
                $"Rent amount: {ProjectedRentalAmt():C} for {complexName} "+
                "\n--------------------------------------------------------------------------\n";
        }
    }
}
