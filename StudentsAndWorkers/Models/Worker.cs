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
    }
}