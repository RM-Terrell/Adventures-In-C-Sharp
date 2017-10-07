using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Practice;

namespace OOP_Practice.Teacher_Student
{
    class StudentTeacherTest
    {
        static void Main(string[] args)
        {
            Person Fred = new Person();
            Fred.SayHello();

            Fred.SetAge(23);
            Fred.ShowAge();

            Student Ragnar = new Student();
            Ragnar.SetAge(21);
            Ragnar.SayHello();
            Ragnar.ShowAge();

            Teacher Tormund = new Teacher();
            Tormund.SetAge(34);
            Tormund.SayHello();
            Tormund.ShowAge();
            Tormund.Explain();

        }
    }
}
