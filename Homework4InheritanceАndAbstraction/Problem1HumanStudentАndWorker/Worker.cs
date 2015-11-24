
using System.Globalization;
using System.Threading;

public class Worker : Human
{
    private readonly decimal WeekSalary;
    private readonly int WorkHoursPerDay;
    private const int WorkDay = 5;

    public Worker(string firstName, string lastName, decimal WeekSalary, int WorkHoursPerDay) 
        : base(firstName, lastName)
    {
        this.WeekSalary = WeekSalary;
        this.WorkHoursPerDay = WorkHoursPerDay;
    }

    public decimal MoneyPerHour()
    {
        int workHoursForWeek = WorkHoursPerDay*WorkDay;
        decimal result = WeekSalary/workHoursForWeek;
        return result;
    }

    public override string ToString()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
        return $"{this.FirstName} {this.LastName} {this.MoneyPerHour():F2}lv.";
    }
}

