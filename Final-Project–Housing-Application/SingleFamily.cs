using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Housing_Application
{
    internal class SingleFamily : Housing
    {
        private decimal rentAmount;
        private decimal sizeInSquareFeet;
        private int numberOfBedrooms;
        private int numerOfBathrooms;
        private bool havePorch;
        private bool hasGarage;

        public decimal RentAmount
        {  get { return rentAmount; } set {  rentAmount = value; } }
        public decimal SizeInSquareFeet
        { get { return sizeInSquareFeet; } set {  sizeInSquareFeet = value; } }
        public int NumberOfBedrooms
        { get { return numberOfBedrooms; } set { numberOfBedrooms = value; } }
        public int NumerOfBathrooms
        { get { return numerOfBathrooms; } set { numerOfBathrooms = value; } }
        public bool HavePorch
        { get { return havePorch; } set { havePorch = value; } }
        public bool HasGarage
        { get { return hasGarage; } set {  hasGarage = value; } }

        public SingleFamily (decimal _rentAmount, decimal _sizeInSquareFeet, int _numberOfBedrooms, int _numerOfBathrooms, bool _havePorch, bool _hasGarage, string _address, string _typeOfConstruction, string _yearBuilt) : base(_address, _typeOfConstruction, _yearBuilt )
        {
            RentAmount = _rentAmount;
            SizeInSquareFeet = _sizeInSquareFeet;
            NumberOfBedrooms = _numberOfBedrooms;
            NumerOfBathrooms = _numerOfBathrooms;
            HavePorch = _havePorch;
            HasGarage = _hasGarage;
        }

        public override decimal ProjectedRentalAmt()
        {
            return rentAmount * 12;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Rent amount: {rentAmount:C} for {numberOfBedrooms} flat with {numerOfBathrooms} bathrooms.\nGarage: {hasGarage}\nPorch: {havePorch}" +
                "\n---------------------------------------------------------------------------------------------\n";
        }

    }
}
