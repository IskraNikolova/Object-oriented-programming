
using Problem2BankOfKurtovoKonare.Interfaces;

public class Deposit : Account, IWithdrawable
{
    public Deposit(Customer customer, decimal balance, decimal interestRate) 
        : base(customer, balance, interestRate)
    {
    }

    public void WithdrawMoney(decimal money)
    {
        this.Balance -= money;
    }

    public override decimal CalculateInterestRate(int months)
    {
        if (this.Balance > 0 && this.Balance < 1000)
        {
            return 0;
        }
        else
        {
            return base.CalculateInterestRate(months);
        }      
    }
}

