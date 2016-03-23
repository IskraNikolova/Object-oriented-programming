namespace Problem3CompanyHierarchy.Person.Customer
{

    using System;
    using Problem3CompanyHierarchy.Interfaces;

    public class Customer : Person, ICustomer
    {
        private decimal amount;

        public Customer(string id, string firstName, string lastName, decimal amount) 
            : base(id, firstName, lastName)
        {
            this.Amount = amount;
        }

        public decimal Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Amount cannot be negative!");
                }

                this.amount = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {this.ID}\nName: {this.FirstName} {this.LastName}\nTotal amount of money: {this.Amount}";
        }
    }
}