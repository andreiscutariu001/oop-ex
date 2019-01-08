using System;

namespace Models
{
    // 4
    public class Student : Human
    {
        // 6
        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            Grade = grade;
        }

        public int Grade { get; }

        public void Print()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}, Grade: {Grade}");
        }
    }
}