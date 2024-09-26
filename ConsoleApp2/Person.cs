using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum Gender { man, woman };
    public class Person
    {
        public Person()
        {
        }

        public string FIO { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Person Mother { get; set; }

        public Person Father { get; set; }                


    }
}
