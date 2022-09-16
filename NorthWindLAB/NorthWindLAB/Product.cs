//Class Product
//Amanda Eng 8-27-22

using System;
namespace NorthWindLAB
{
    public class Product
    {
        //defualt values aka class variables 
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = 9999.99;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = 999999;
        private bool discontinued = true;



        //gets and sets (properties)
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
        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }

        }
        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if (value > -1)
                {
                    this.supplierId = value;
                }

            }
        }
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                if (value > -1)
                {
                    this.categoryId = value;
                }

            }
        }
        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value; }

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
        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set
            {
                if (value > -1)
                {
                    this.unitsInStock = value;
                }

            }
        }
        public int UnitsOnOrder
        {
            get { return this.unitsOnOrder; }
            set
            {
                if (value > -1)
                {
                    this.unitsOnOrder = value;
                }

            }
        }
        public int ReorderLevel
        {
            get { return this.reorderLevel; }
            set
            {
                if (value > 0)
                {
                    this.reorderLevel = value;
                }
            }
        }
        public bool Discontinued
        {
            get { return this.discontinued; }
            set { this.discontinued = value; }
        }


        //ToString
        public override string ToString()
        {
            string message = "";

            message = message + "Product Id: " + this.ProductId + "\n";
            message = message + "Product Name: " + this.ProductName + "\n";
            message = message + "Supplier Id: " + this.SupplierId + "\n";
            message = message + "Category Id: " + this.CategoryId + "\n";
            message = message + "Quantity Per Unit: " + this.QuantityPerUnit + "\n";
            message = message + "Unit Price: " + this.UnitPrice + "\n";
            message = message + "Units in Stock: " + this.UnitsInStock + "\n";
            message = message + "Units On Order: " + this.UnitsOnOrder + "\n";
            message = message + "Reorder Level: " + this.ReorderLevel + "\n";
            message = message + "Discontinued: " + this.Discontinued + "\n";
            return message;



        }
    }
}

