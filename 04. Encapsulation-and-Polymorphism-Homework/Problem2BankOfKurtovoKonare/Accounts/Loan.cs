namespace Problem2BankOfKurtovoKonare.Accounts
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestRate(int months)
        {
            if (this.Customer.Type == "individuals")
            {
                return base.CalculateInterestRate(months - 3);
            }
            else
            {
                return base.CalculateInterestRate(months - 2);
            }       
        }
    }
}