//Class Order Details
//Amanda Eng
//8-27-22

using System;
namespace NorthWindLAB
{
    public class OrderDetail
    {
        //class varablies aka defualt varablies 
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = 9999.99;
        private int quantity = 0;
        private double discount = 0.0;


        //gets and sets properties 
        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                if (value > -1)
                {
                    this.orderId = value; //pass in the deafaut value
                }

            }
        }
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                if (value > -1)
                {
                    this.productId = value;
                }

            }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                if (value > 0.0)
                {
                    this.unitPrice = value;
                }

            }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value > 0)
                {
                    this.quantity = value;
                }

            }
        }
        public double Discount
        {
            get { return this.discount; }
            set
            {
                if (value >= 0.0)
                {
                    this.discount = value;
                }

            }
        }


        public override string ToString()
        {
            string message = "";

            message = message + "Order Id: " + this.OrderId + "\n";
            message = message + "Product Id: " + this.ProductId + "\n";
            message = message + "Unit Price: " + this.UnitPrice + "\n";
            message = message + "Quantity: " + this.Quantity + "\n";
            message = message + "Discount: " + this.Discount + "\n";
            return message;

        }

    }
}


