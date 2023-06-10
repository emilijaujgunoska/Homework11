using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Student : Person
    {
        private int gradeLevel;


        public int GradeLevel
        {
            get { return gradeLevel; }
            set { gradeLevel = value; }
        }
        public Student(string name, int gradeLevel) : base(name) 
        {
            this.gradeLevel = gradeLevel;
        }

        public override void Greet()
        {
           
            Console.WriteLine($"Hello, my name is {name} and I'm in grade {gradeLevel}");
        }

    }
}
