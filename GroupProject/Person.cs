using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Person
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }
        

        //Constructor
        public Person(string _name,int _age)
        {
            Name = _name;
            Age = _age;
        }

    }
}
