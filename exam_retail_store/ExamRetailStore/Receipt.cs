using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ExamRetailStore
{
    internal class Receipt
    {
        private int _receiptNumber;
        private int _customerNumber;
        private int _itemNumber;
        private double _unitPrice;
        private double _quantityPurchased;
        private string _customerName;
        private string _customerAddress;
        private string _customerPhoneNumber;
        private string _description;
        private DateTime _dateOfPurcase;

        //Getter and setter

        public int ReceiptNumber
        {
            get { return _receiptNumber; }
            set
            {
                if (value <= 0) _receiptNumber = 1;
                else _receiptNumber = value;
            }
        }

        public int CustomerNumber
        {
            get { return _customerNumber; }
            set
            {
                if (value <= 0) _customerNumber = 1;
                else _customerNumber = value;
            }
        }

        public int ItemNumber {
            get { return _itemNumber; }
            set
            {
                if (value <= 0 || value > 9999) _itemNumber = 1;
                else _itemNumber = value;
            }

        }
        public double UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (value <= 0 || value > 9999) _unitPrice = 1;
                else _unitPrice = value;
            }

        }

        public double QuantityPurchased
        {
            get { return _quantityPurchased; }
            set
            {
                if (value <= 0) _quantityPurchased = 1;
                else _quantityPurchased = value;
            }
        }
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }
        public string CustomerAddress { get { return _customerAddress; } set { _customerAddress = value; } }
        public string CustomerPhoneNumber { get { return _customerPhoneNumber; } set { _customerPhoneNumber = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public DateTime DateOfPurcase { get { return _dateOfPurcase; } set { _dateOfPurcase = value; } }


        public  Receipt(
            int receiptNumber,
            int customerNumber,
            string customerName,
            string customerAddress,
            string customerPhoneNumber,
            int itemNumber,
            string description,
            double unitPrice,
            double quantityPurchased,
            DateTime dateOfPurchase = default( DateTime)
            ) 
        {
            this.ReceiptNumber = receiptNumber;
            this.CustomerNumber = customerNumber;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.CustomerPhoneNumber = customerPhoneNumber;
            this.ItemNumber = itemNumber;
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.QuantityPurchased = quantityPurchased;
            if (dateOfPurchase == default(DateTime))
            {
                dateOfPurchase = DateTime.Now;
            }

        }

        public override string ToString()
        {
            return $"Customer {CustomerName}\nPhone: {CustomerPhoneNumber}\nTotal Purchases: {CustomerTotalCost()}";
        }

        private double CustomerTotalCost()
        {
            return (double)(QuantityPurchased * UnitPrice);
        }
    }
}
