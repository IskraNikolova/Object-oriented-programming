namespace Problem2BankOfKurtovoKonare.Accounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestRate(int months)
        {
            decimal result;
            if (this.Customer.Type == "individuals")
            {
                result = months <= 6 ? 0 : base.CalculateInterestRate(months - 6);
        
            }
            else
            {
                if (months <= 12)
                {
                    result = base.CalculateInterestRate(months)/2;
                }
                else
                {
                    decimal firstMounth = base.CalculateInterestRate(12) / 2;
                    decimal secondMonth = base.CalculateInterestRate(months - 12);
                    result = firstMounth + secondMonth;
                }
            }

            return result;
        }
    }
}