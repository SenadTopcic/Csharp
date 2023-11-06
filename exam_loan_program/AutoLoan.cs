using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_loan_program
{
    internal class AutoLoan : Loan
    {
        private string yearBuilt;
        private string model;
        private string make;
        private string color;

        public AutoLoan(string _loanNumber, string _customerFirstName, string _customerLastName, decimal _interestRate, decimal _loanAmount, int _numberOfYEarsinLoanTerm, string _yearBuilt, string _model, string _make, string _color) : base(_loanNumber, _customerFirstName, _customerLastName, _interestRate, _loanAmount, _numberOfYEarsinLoanTerm)
        {
            YearBuilt = _yearBuilt;
            Model = _model;
            Make = _make;
            Color = _color;
        }
        public string YearBuilt { get { return yearBuilt; } set { yearBuilt = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Make { get { return make; } set { make = value; } }
        public string Color { get { return color; } set { color = value; } }


        public override decimal CalculateInterest()
        {
            // Convert annual interest rate to monthly rate
            decimal monthlyInterestRate = base.InterestRate / 100;
            // Calculate the total loan principal (including admin fee of $1000)
            decimal totalPrincipal = LoanAmount + 1000;

            // Calculate the number of payments in months
            decimal numberOfPayments = NumberOfYears / 12M;

            // Calculate the interest using the formula
            decimal interest = ((monthlyInterestRate / numberOfPayments) * totalPrincipal);
            return interest;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                    $"Interest amount {CalculateInterest():C}\n" +
                    $"Model :{Model} \nMake :{Make} \nColor :{Color} \n";
        }
    }
}

