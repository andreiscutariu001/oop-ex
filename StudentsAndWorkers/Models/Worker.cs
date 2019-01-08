namespace Models
{
    // 5
    public class Worker : Human
    {
        // 6
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary { get; }

        public int WorkHoursPerDay { get; }

        // 10
        public double MoneyPerHour()
        {
            var moneyPerDay = (double) WeekSalary / 7;
            return moneyPerDay / WorkHoursPerDay;
        }
    }
}