using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_loan_program
{
    abstract class Loan
    {
        private string loanNumber;
        private string customerFirstName;
        private string customerLastName;
        private decimal interestRate;
        private decimal loanAmount;
        private int numberOfYEarsinLoanTerm;

        public string LoanNumber {
            get { return loanNumber; }
            set
            {
                if (value == null || value == "")
                {
                    value = "0000001";
                }
                loanNumber = value;
            }
        }
        public string CustomerFirstName
        { 
            get { return customerFirstName; } 
            set {
                if (value == string.Empty)
                {
                    value = "John";
                }
                customerFirstName = value;
            } 
        }
        public string CustomerLastName 
        {
            get { return customerLastName; } 
            set
            {
                if (value == string.Empty)
                {
                    value = "Doe";
                }
                customerLastName = value;
            }

        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set {
                interestRate = Math.Max(value, 0);
            }
        }
        public decimal LoanAmount
        {
            get { return loanAmount; }
            set
            {
                loanAmount = Math.Max(value, 0);
            }
        }

        public int NumberOfYears
        {
            get { return  numberOfYEarsinLoanTerm; }
            set { numberOfYEarsinLoanTerm = Math.Max(value, 0); }
        }

        public Loan(string _loanNumber, string _customerFirstName, string _customerLastName, decimal _interestRate, decimal _loanAmount, int _numberOfYEarsinLoanTerm)
        {
            LoanNumber = _loanNumber;
            CustomerFirstName = _customerFirstName;
            CustomerLastName = _customerLastName;
            InterestRate = _interestRate;
            LoanAmount = _loanAmount;
            NumberOfYears = _numberOfYEarsinLoanTerm;
        }

        public override string ToString() 
        {
            return $"Loan number: {LoanNumber}\n" +
               $"Customer First Name: {CustomerFirstName}\n" +
               $"Customer Last Name: {CustomerLastName}\n" +
               $"Interest Rate: {InterestRate}%\n" +
               $"Loan Amount: ${LoanAmount}\n" +
               $"Number of Years in the loan's term: {NumberOfYears}";
        }

        public abstract decimal CalculateInterest();

    }
}
