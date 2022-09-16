//Amanda Eng 8-27-22
//Class Shipper


using System;
namespace NorthWindLAB
{
    public class Shipper
    {
        //class variables
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        //gets and sets

        public int ShipperId
        {
            get { return this.shipperId; }
            set
            {
                if (value > -1)
                {
                    this.shipperId = value;
                }
            }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }

        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }

        }


        //ToString
        public override string ToString()
        {
            string message = "";

            message = message + "Shipper Id: " + this.ShipperId + "\n";
            message = message + "Company Name: " + this.CompanyName + "\n";
            message = message + "Phone: " + this.Phone + "\n";
            return message;

        }

    }
}

