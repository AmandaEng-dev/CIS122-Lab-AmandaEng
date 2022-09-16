//Class Employee
//Amanda Eng
//8-27-22

using System;
namespace NorthWindLAB
{
    public class Employee
    {
        //Default values aka class varablies
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        //gets and sets!!

        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                if (employeeId >= 0)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = 0; //dont need this else statement technically. would just pass into the deafult, which is already 0
                }

            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public string HireDate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public int ReportsTo
        {
            get { return this.reportsTo; }
            set
            {
                if (value >= 0)
                {
                    this.reportsTo = value;
                }
                   
            }

        }

        //Methods


        //empty constructor
        public Employee (): this (-1,"n/a", "n/a,", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a",- 1)
        {

        }

        //full constructor
        public Employee(int aEmployeeID, string aLastName,string aFirstName,string aTitle,string aTitleOfCourtesy,string aBirthdate,string aHireDate,string aAddress,string aCity, string aRegion,string aPostalCode, string aCountry, string aHomePhone, string aExtension, int aReportsTo)
        {
            this.EmployeeId = aEmployeeID;
            this.LastName = aLastName;
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.BirthDate = aBirthdate;
            this.HireDate = aHireDate;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.HomePhone = aHomePhone;
            this.Extension = aExtension;
            this.ReportsTo = aReportsTo;

        }

        //ToString

        public override string ToString()
        {
            string message = "";

            message = message + "Employee Id: " + this.EmployeeId + "\n";
            message = message + "Last Name: " + this.LastName + "\n";
            message = message + "First Name: " + this.FirstName + "\n";
            message = message + "Title: " + this.Title + "\n";
            message = message + "Title of Courtesy: " + this.TitleOfCourtesy + "\n";
            message = message + "Birth Date: " + this.BirthDate + "\n";
            message = message + "Hire Date: " + this.HireDate + "\n";
            message = message + "Address: " + this.Address + "\n";
            message = message + "City: " + this.City + "\n";
            message = message + "Region: " + this.Region + "\n";
            message = message + "Postal Code: " + this.PostalCode + "\n";
            message = message + "Country: " + this.Country + "\n";
            message = message + "Home Phone: " + this.HomePhone + "\n";
            message = message + "Extension: " + this.Extension + "\n";
            message = message + "Country: " + this.Country + "\n";
            message = message + "Reports To: " + this.ReportsTo + "\n";
            return message;
        }




    }
}

