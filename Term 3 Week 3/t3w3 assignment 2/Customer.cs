using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3w3_assignment_2
{
    class Customer
    {
        private string name;
        private int age;
        private DateTime registerationDate;
        private DateTime dob;
        private bool discount;
        public Customer(string name, DateTime dob)
        {
            Name = name;
            Dob = dob;
            Age = age;
            registerationDate = DateTime.Now.AddYears(-1);
            Discount = false;
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }
            set
            {
                if (DateTime.Now.CompareTo(value)>0)
                {
                    dob = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null && value !=" ")
                {
                    name = value;
                }
                else
                {
                    name = "John/Jane Doe";
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age=DateTime.Today.Year - dob.Year;

            }
        }
        public bool Discount
        {
            get
            {
                return discount;
            }
            set
            {
                TimeSpan DiscountCheck = DateTime.Today.Subtract(registerationDate);
                if(DiscountCheck.TotalDays>=365)
                {
                    discount = true;
                }
                else
                {
                    discount = false;
                }
              
            }
        }
        public DateTime Date
        {
            get
            {
               return registerationDate;
            }
            set
            {
                registerationDate = value;
            }
           
        }

       
    }
}
