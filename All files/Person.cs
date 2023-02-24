using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        protected static int nextID = 1;


        public Person(string name, string email, string notes = "this is a sample note")
        {
            Name = name;
            Email = email;
            ID = nextID++;
            Notes = notes;
        }

        public virtual string Details()
        {
            return string.Format($"{ID}, {Name}, {Email}, {Notes}");
        }

        public override string ToString()
        {
            return Details();
        }

    }
}
