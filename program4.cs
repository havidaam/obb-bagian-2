teacher.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Sustudent.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    class Student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        public Student(string Name, int Age, string StudentId, string Email): base (Name, Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.StudentId = StudentId;
            this.Email = Email;
        }
    }
}bject { get; set; }

        public Teacher(string Name, int Age, string TeacherId, string Subject): base (Name, Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.TeacherId = TeacherId;
            this.Subject = Subject;
        }
    }
}