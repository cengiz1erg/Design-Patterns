using System;

namespace AccessModifiersV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Cengiz");
        }
    }

    class Person
    {
        protected string Name { get; set; }

        protected Person(string data)
        {
            this.Name = data;
        }
    }

    class Student : Person
    {
        public Student(string data): base(data)
        {
            
        }
    }
}
