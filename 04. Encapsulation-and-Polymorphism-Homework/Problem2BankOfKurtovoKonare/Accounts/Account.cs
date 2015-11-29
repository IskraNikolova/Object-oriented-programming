
using System;
using Problem2BankOfKurtovoKonare.Interfaces;

public abstract class Account : IInterestRate, IDepositable
{
    private decimal balance;
    private decimal interestRate;

    protected Account(Customer customer, decimal balance, decimal interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    public Customer Customer { get; set; }

    public decimal Balance
    {
        get { return this.balance; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be negative!");
            }
            this.balance = value;
        }
    }

    public decimal InterestRate
    {
        get { return this.interestRate; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Interest rate cannot be negative!");
            }
            this.interestRate = value;
        }
    }

    public virtual decimal CalculateInterestRate(int months)
    {
        return this.Balance*(1 + this.InterestRate*months);
    }

    public void DepositMoney(decimal money)
    {
        this.Balance += money;
    }

    public override string ToString()
    {
        return
            $"{GetType().Name} account of {this.Customer.Type} type has {this.Balance} and {this.InterestRate} interest rate(monthly based).";
    }
}

