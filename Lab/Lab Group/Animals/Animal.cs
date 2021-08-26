using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public string Name{ get; protected set; }
        public string FavouriteFood { get; protected set; }

        protected Animal(string name,string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }


        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
