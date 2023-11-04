using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfSectionExam_ResaleValue
{
    internal class ItemPrice
    {
        private double _itemPrice;
        private List<(double, double, double)> itemsPrices;

        public ItemPrice(double itemPrice)
        {
            Item_price = itemPrice;
            itemsPrices = new List<(double, double, double)>();
        }


        public double Item_price
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }
        }
        
        public void CreateNewPrices()
        {
            for (double i = 5; i <= 10; i++)
            {
                double price = Item_price * i / 100;
                double newPrice = price + Item_price;
                itemsPrices.Add(( i, price, newPrice));
            }
             
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            CreateNewPrices();

            result.AppendLine("Markup (%)   | Initial Price   | Markup Amount       | New Price");
            result.AppendLine("------------ | --------------- | ------------------- | -----------");

            foreach (var (percentage, price, newPrice) in itemsPrices)
            {
                result.AppendLine($"{percentage + "%",-12} | {Item_price,-15:C} | {price,-19:C} | {newPrice:C}");
            }

            return result.ToString();
        }
        
    }
  
}
