using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Person
    {
        protected string name;
        public Person(string name) 
        {
            this.name = name;
        }
        
        
       public virtual void Greet ()
        {
            Console.WriteLine("Hello my name is " + name);
        }
       
    }
}
