using System;


namespace CustomerData
{
    public class Customer
    {
        //private data
        private int account;
        private decimal charge;


        // class constructor
        public Customer(int a = 1, string n = "unknown", string ct = "unknown", decimal c = 0)
        {
            Account = a;
            Name = n;
            CustType = ct;
            Charge = c;
        }

        // public properties
        public int Account
        {
            get
            {
                return account;
            }
            set
            {
                if (value >= 0)
                {
                    account = value;
                }
                else // when negative, take absolute value
                {
                    account = Math.Abs(value);
                }
            }
        }

        public decimal Charge
        {
            get
            {
                return charge;
            }
            set
            {
                if (value >= 0)
                {
                    charge = value;
                }
                else // when negative, take absolute value
                {
                    charge = Math.Abs(value);
                }
            }
        }

        // auto-implemented property
        // automatically declares unnamed private variable
        public string Name { get; set; } // default code; no validation
        public string CustType { get; set; } // default code; no validation

        // public methods
        public decimal SumCharges()
        {
            return charge;
        }

        public decimal SumResidential()
        {
            if (CustType == "R")
            {
                return charge;
            }
            else
            {
                return 0;
            }
        }

        public decimal SumCommercial()
        {
            if (CustType == "C")
            {
                return charge;
            }
            else
            {
                return 0;
            }
        }

        public decimal SumIndustrial()
        {
            if (CustType == "I")
            {
                return charge;
            }
            else
            {
                return 0;
            }
        }

        // redefine (override) method ToString that was inheritted from object class
        public override string ToString()
        {
            return Account + ": " + Name + ", " + CustType.ToString() + ", " + Charge.ToString("c");
        }

        public string ToFileLine() // CSV, no formatting
        {
            return Account + "," + Name + "," + CustType.ToString() + "," + Charge.ToString();
        }

    }
}
