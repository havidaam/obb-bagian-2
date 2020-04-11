program.cs

using System;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Vina", 18);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Vida", 20, "190302", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Afi", 18, "10506", "Afi@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}