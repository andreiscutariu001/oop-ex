using System.Collections.Generic;
using Models;

namespace App
{
    /*
        Define abstract class Human with a first name and a last name.
        Define a new class Student which is derived from Human and has a new field – grade.
        Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker.
        Define the proper constructors and properties for this hierarchy.
        Initialize a list of 10 students and sort them by grade in ascending order.
        Initialize a list of 10 workers and sort them by money per hour in descending order.
        Merge the lists and sort them by first name and last name.
    */

    internal class Program
    {
        // 1. Creem un nou proiect numit Models unde o sa scriem clasele din problema de mai sus
        // 2. Adaug referinta de la proiectul consola catre proiectul Models. In felul acesta proiectul App are access la cod din proiectul Models
        // 3. Creem o noua clasa in proiectul Models numita Human (Click dreapta pe proiect => Add => Class). Adaug field-urile necesare. 
        // 4. Adaugam clasa Student. Mostenim din clasa Human.
        // 5. Adaugam clasa Worker. Mostenim din clasa Human.
        // 6. Adaugam constructori pentru clasele adaugate.
        // 7. Creem o lista de studenti (o sa fac 3, nu 10 :))
        // 8. Creem o clasa statica helper unde o sa scriem cod pt liste (afisat, gasit element, sortat)
        // 9. Creem o metoda de afisat studentii
        // 10. Creem o metoda de sortat studentii - o sa folisim buble sort
        // 11. Adaugam metoda MoneyPerHour in clasa worker pe care o sa o folosim pt sortare.
        // 12. Creem o lista noua de workers
        // 13. TODO o metoda de afisat Workers
        // 14. TODO o medoda de sortat Workers.
        // 15. TODO o lista noua de tip Human. Adauga ambele liste in ea (workers and students)
        // 16. TODO o metoda noua de afisat lista de la pasul 15
        // 17. TODO o metoda noua de sortat Students

        private static void Main(string[] args)
        {
            //7
            var students = new List<Student>
            {
                new Student("Andrei", "Popescu", 1),
                new Student("Vasile", "Popescu", 3),
                new Student("Dan", "Popescu", 2)
            };

            //9
            StudentsAndWorkersListHelper.Print(students);

            //10
            StudentsAndWorkersListHelper.Sort(students);
            StudentsAndWorkersListHelper.Print(students);

            //12
            var workers= new List<Worker>
            {
                new Worker("Ion", "Pop", 1000, 40),
                new Worker("Daria", "Pop", 1000, 20),
                new Worker("Anca", "Pop", 2000, 10)
            };

            //13
            // ...
        }
    }

    // 8
    public static class StudentsAndWorkersListHelper
    {
        // 9
        public static void Print(List<Student> students)
        {
            foreach (var student in students)
            {
                student.Print();
            }
        }

        // 10
        public static void Sort(List<Student> students)
        {
            Student aux;

            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students.Count; j++)
                {
                    if (students[i] < students[j])
                    {
                        aux = students[i];
                        students[i] = students[j];
                        students[j] = aux;
                    }   
                }
            }
        }
    }
}