using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exam_Property_tax_calculator
{
    internal class Property
    {
        private string _propertyAddress;
        private decimal _lastYearAssessedValue;
        private decimal _currentAssessedValue;
        private decimal _taxableValue;
        private decimal _taxesDue;
        private readonly decimal _millageRatePer1000 = 10.03M;
        private readonly decimal _exemption = 25_000M;
        private readonly decimal _townshipTaxPercentage = 0.027M;

        public Property(string propertyAddress, decimal lastYearAssessedValue, decimal currentAssessedValue)
        {
            PropertyAddress = propertyAddress;
            LastYearAssessedValue = lastYearAssessedValue;
            CurrentAssessedValue = currentAssessedValue;
            TaxableValue = CalculateTaxesValue();
            TaxesDue = CalculateTaxesDue();

        }

        public string PropertyAddress
        {
            get { return _propertyAddress; }
            set { _propertyAddress = value; }
        }

        public decimal LastYearAssessedValue
        {
            get { return _lastYearAssessedValue; }
            set { _lastYearAssessedValue = Math.Max(value, 0); }
        }

        public decimal CurrentAssessedValue
        {
            get { return _currentAssessedValue; }
            set { _currentAssessedValue = Math.Max(value, 0); }
        }

        public decimal TaxableValue
        {
            get { return _taxableValue; }
            set { _taxableValue = value; }
        }

        public decimal TaxesDue
        {
            get { return _taxesDue; }
            private set { _taxesDue = (TaxableValue / 1000) * _millageRatePer1000; }
        }

        private decimal CalculateTaxesValue()
        {
            return (CurrentAssessedValue - _exemption);
        }

        private decimal CalculateTaxesDue()
        {
            return (CalculateTaxesValue() * _millageRatePer1000) / 1000;
        }
        public decimal NextYearAssessedValue()
        {
            return CurrentAssessedValue * (1 + _townshipTaxPercentage);
        }
        public override string ToString()
        {
            return $"Property Address: {_propertyAddress}\n" +
                $"Last Year Assessed Value: {_lastYearAssessedValue:C}\n" +
                $"Current Assessed Value: {_currentAssessedValue:C}\n" +
                $"Exemption: {_exemption:C}\n" +
                $"Taxable Value: {_taxableValue:C}\n" +
                $"Millage Rate (per $1000): {_millageRatePer1000:C}\n" +
                $"Taxes Due: {_taxesDue:C}";
        }
    }
}
