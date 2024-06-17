using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstDBSetup
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        /*
        public PersonModel(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        */
    }
}
