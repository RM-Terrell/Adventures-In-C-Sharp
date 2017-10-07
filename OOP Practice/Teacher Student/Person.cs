using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Teacher_Student
{
    class Person
    {
        private int Age;        
        public void SetAge(int age) => Age = age;
        public void ShowAge() => Console.WriteLine("My age is {0}", Age);
        public void SayHello() => Console.WriteLine("Hello!");        
    }
}
