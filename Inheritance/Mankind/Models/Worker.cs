using System.Text;

namespace Mankind.Models
{
    using System;

    public class Worker : Human
    {
        private const int WorkDayInWeek = 5;

        private double weekSalary;
        private double hoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double hoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public double HoursPerDay
        {
            get
            {
                return this.hoursPerDay;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.hoursPerDay = value;
            }
        }

        public double SalaryPerHour
        {
            get
            {
                double salaryForDay = WeekSalary/5;
                double salaryPerHour = salaryForDay / this.HoursPerDay;

                return salaryPerHour;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            output.AppendLine($"Hours per day: {this.HoursPerDay:F2}");
            output.AppendLine($"Salary per hour: {this.SalaryPerHour:F2}");

            return base.ToString() + output;
        }
    }
}
