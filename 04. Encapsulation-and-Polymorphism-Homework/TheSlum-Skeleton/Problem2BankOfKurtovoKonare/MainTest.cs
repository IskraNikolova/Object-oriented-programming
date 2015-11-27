using System;

public class MainTest
{
    public static void Main()
    {
        Deposit depositAccount = new Deposit(new Customer("individuals"), 2900, 0.01m);
        depositAccount.DepositMoney(300.50m);
        depositAccount.WithdrawMoney(100.00m);
        int months = 6;
        Console.WriteLine(depositAccount);
        Console.WriteLine("Interest rate for {0} months of is {1:F2}lv.", months,
            depositAccount.CalculateInterestRate(months));
        Console.WriteLine("________________________________");


        Loan loanAccount = new Loan(new Customer("individuals"), 6400.0m, 0.01m);
        loanAccount.DepositMoney(500.0m);
        int month = 7;
        Console.WriteLine(loanAccount);
        Console.WriteLine("Interest rate for {0} months is {1:F2}lv.", month,
            loanAccount.CalculateInterestRate(month));
        Console.WriteLine("________________________________");


        Loan loanAccountCompany = new Loan(new Customer("companies"), 6400.0m, 0.01m);
        loanAccountCompany.DepositMoney(500.0m);
        Console.WriteLine(loanAccountCompany);
        Console.WriteLine("Interest rate for {0} months is {1:F2}lv.", month,
            loanAccountCompany.CalculateInterestRate(month));
        Console.WriteLine("________________________________");
        

        Mortgage mortgageAccount = new Mortgage(new Customer("individuals"), 3200.00m, 0.01m);
        mortgageAccount.DepositMoney(6700.0m);
        int monthForMortage = 15;
        Console.WriteLine(mortgageAccount);
        Console.WriteLine("Interest rate for {0} months is {1:F2}lv.", monthForMortage,
            mortgageAccount.CalculateInterestRate(monthForMortage));
        Console.WriteLine("________________________________");


        Mortgage mortgageAccountCompany = new Mortgage(new Customer("companies"), 23200.00m, 0.01m);
        mortgageAccountCompany.DepositMoney(100.0m);
        Console.WriteLine(mortgageAccountCompany);
        Console.WriteLine("Interest rate for {0} months is {1:F2}lv.", monthForMortage,
            mortgageAccountCompany.CalculateInterestRate(monthForMortage));
    }
}

