
using System;

namespace Problem3CompanyHierarchy.Person.Customer
{
    public class Customer : global::Person
    {
        private decimal amount;
        public Customer(string id, string firstName, string lastName, decimal amount) 
            : base(id, firstName, lastName)
        {
            this.Amount = amount;
        }

        public decimal Amount
        {
            get { return this.amount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Amount cannot be negatrive!");
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
