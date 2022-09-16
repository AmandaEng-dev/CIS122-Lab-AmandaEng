//Category Class
//Amanda Eng
//8-26-22


using System;
namespace NorthWindLAB
{
    public class Category
    {
        //class variables (instances)
        private int categoryId = -1;
        private string description = "n/a"; //we always want DEFAULT values
        private string categoryName = "n/a";


        //accessors and mutators (gets and sets)
        public int CategoryId
        {
            get { return this.categoryId = 1; }
            set
            {

                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }

            }

        }

        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }

        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        
        //Methods



        //Empty and Full Constructor

        public Category (): this(-1, "n/a","n/a")
        {
        }

        public Category (int aCategoryId, string aDescription, string aCategoryName)
        {
            this.CategoryId = aCategoryId;
            this.Description = aDescription;
            this.CategoryName = aCategoryName;

        }






        //ToString write out objects in string format

        public override string ToString()
        {
            string message = "";

            message = message + "Category Id: " + this.CategoryId + "\n";
            message = message + "Category Name: " + this.CategoryName + "\n";
            message = message + "Description: " + this.Description + "\n";

            return message;
        }

    }

}




