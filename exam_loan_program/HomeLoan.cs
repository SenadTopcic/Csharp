using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace exam_loan_program
{
    internal class HomeLoan : Loan
    {
        private string address;
        private string yearBuilt;
        private string squareFootage;

        public HomeLoan(string _loanNumber, string _customerFirstName, string _customerLastName, decimal _interestRate, decimal _loanAmount, int _numberOfYEarsinLoanTerm, string _address, string _yearBuilt, string _squareFootage) : base(_loanNumber, _customerFirstName, _customerLastName, _interestRate, _loanAmount, _numberOfYEarsinLoanTerm)
        {
            Address = _address;
            YearBuilt = _yearBuilt;
            SquareFootage = _squareFootage;
        }
        public string Address { get { return address; } set { address = value; } }
        public string YearBuilt { get { return yearBuilt; } set {  yearBuilt = value; } }   
        public string SquareFootage { get { return squareFootage; } set { squareFootage = value; } }


        public override decimal CalculateInterest()
        {
            // Convert annual interest rate to monthly rate
            decimal monthlyInterestRate = base.InterestRate / 100;
            // Calculate the total loan principal (including admin fee of $5000)
            decimal totalPrincipal = LoanAmount + 5000;

            // Calculate the number of payments in months
            decimal numberOfPayments = NumberOfYears / 12M;

            // Calculate the interest using the formula
            decimal interest = ((monthlyInterestRate / numberOfPayments) * totalPrincipal);
            return interest;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                    $"Interest amount {CalculateInterest():C} ";
        }
    }

}
