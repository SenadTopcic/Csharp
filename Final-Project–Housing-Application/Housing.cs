using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Housing_Application
{
    internal class Housing
    {
        private string address;
        private string typeOfConstruction;
        private string yearBuilt;

        public Housing(string _address, string _typeOfConstruction, string _yearBuilt) 
        {
            Address = _address;
            TypeOfConstruction = _typeOfConstruction;
            YearBuilt = _yearBuilt;

        }

        public string Address { get { return address; } set {  address = value; } }
        public string TypeOfConstruction { get { return typeOfConstruction; } set { typeOfConstruction = value; } }
        public string YearBuilt {  get { return yearBuilt; } set {  yearBuilt = value; } }  

        public virtual decimal ProjectedRentalAmt()
        {

            return 0M;
        }

        public override string ToString()
        {
            return $"Address: {address}\nType of construction: {typeOfConstruction}\nYear built: {yearBuilt}\n";
        }

    }
}
