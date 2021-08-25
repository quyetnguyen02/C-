using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8._1
{
   public class Citizen : IPerson,IIdentifiable,IBirthable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string id { get; set; }

        public string Birthday { get; set; }

        public Citizen(string name, int age,string id,string birthday)
        {
            Name = name;
            Age = age;
            id = id;
            Birthday = birthday;
        }

    }
}
