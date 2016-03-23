namespace Problem2BankOfKurtovoKonare
{
    using System;

    public class Customer
    {
        private string type;

        public Customer(string type)
        {
            this.Type = type;
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                if (value != "individuals" && value != "companies")
                {
                    throw new FormatException("Customer must be \"individuals\" or \"companies\"");
                }

                this.type = value;
            }
        }
    }
}