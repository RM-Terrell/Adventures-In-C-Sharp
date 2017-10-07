using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Teacher_Student
{
    class Teacher : Person
    {
        private string LectureSubject;

        public void Explain()
        {
            Console.WriteLine("I am the teacher starting the lecture.");            
        }
    }
}
