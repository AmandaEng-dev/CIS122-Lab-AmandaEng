//Class Order
//Amanda Eng
//8-27-22

using System;
namespace NorthWindLAB
{
    public class Order
    {
        //defualt values aka class variables    
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private string orderDate = "n/a";
        private string requireDate = "n/a";
        private string shipDate = "n/a";
        private int shipVia = -1;
        private double freight = 9999.99;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";


        //gets and sets, aka properites

        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                if (value > -1)
                {
                    this.orderId = value;
                }

            }
        }
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }

        }
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                if (value > -1)
                {
                    this.employeeId = value;
                }

            }
        }
        public string OrderDate
        {
            get { return this.orderDate; }
            set { this.orderDate = value; }

        }

        public string RequireDate
        {
            get { return this.requireDate; }
            set { this.requireDate = value; }

        }
        public string ShipDate
        {
            get { return this.shipDate; }
            set { this.shipDate = value; }

        }
        public int ShipVia
        {
            get { return this.shipVia; }
            set
            {
                if (value > -1)
                {
                    this.shipVia = value;
                }

            }
        }
        public double Freight
        {
            get { return this.freight; }
            set
            {
                if (value >= 0.0)
                {
                    this.freight = value;
                }

            }
        }
        public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }
        public string ShipAddress
        {
            get { return this.shipAddress; }
            set { this.shipAddress = value; }
        }
        public string ShipCity
        {
            get { return this.shipCity; }
            set { this.shipCity = value; }
        }
        public string ShipRegion
        {
            get { return this.shipRegion; }
            set { this.shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return this.shipPostalCode; }
            set { this.shipPostalCode = value; }
        }
        public string ShipCountry
        {
            get { return this.shipCountry; }
            set { this.shipCountry = value; }
        }

        //ToString

        public override string ToString()
        {
            string message = "";

            message = message + "Order Id: " + this.OrderId + "\n";
            message = message + "Customer Id: " + this.CustomerId + "\n";
            message = message + "Employee Id: " + this.EmployeeId + "\n";
            message = message + "Order Date: " + this.OrderDate + "\n";
            message = message + "Require Date: " + this.RequireDate + "\n";
            message = message + "Ship Via: " + this.ShipVia + "\n";
            message = message + "Ship Date: " + this.ShipDate + "\n";
            message = message + "Freight: " + this.Freight + "\n";
            message = message + "Ship Name: " + this.ShipName + "\n";
            message = message + "Ship Address: " + this.ShipAddress + "\n";
            message = message + "Ship City: " + this.ShipCity + "\n";
            message = message + "Ship Region: " + this.ShipRegion + "\n";
            message = message + "Ship Postal Code: " + this.ShipPostalCode + "\n";
            message = message + "Ship Country: " + this.ShipCountry + "\n";
            return message;


        }
    }
}