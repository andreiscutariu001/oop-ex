using System;
using System.Diagnostics;

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

        public static bool operator <(Student s1, Student s2)
        {
            if (s1.Grade < s2.Grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Student s1, Student s2)
        {
            if (s1.Grade > s2.Grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}