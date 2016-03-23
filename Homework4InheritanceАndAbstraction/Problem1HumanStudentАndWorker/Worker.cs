namespace Problem1HumanStudentАndWorker
{
    using System.Globalization;
    using System.Threading;

    public class Worker : Human
    {
        private const int WorkDay = 5;

        private readonly decimal weekSalary;
        private readonly int workHoursPerDay;
        
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            int workHoursForWeek = workHoursPerDay * WorkDay;
            decimal result = weekSalary / workHoursForWeek;

            return result;
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
            return base.ToString() + $" - money for hour {this.MoneyPerHour():F2}lv.";
        }
    }
}