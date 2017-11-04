using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class_Stoyan
{
    class Student
    {
        public string name { get; set; } //property , a bez skobite e "field"
        public int age { get; set; }    //property
        public int id { get; set; }     //property

        public Student(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Gosho", 25, 123123);
            Console.WriteLine(s.name);
            Console.WriteLine(s.age);
            Console.WriteLine(s.id);
        }
    }
}
