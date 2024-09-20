using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_arv_polymorfism
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof!");
        }

        public override string Stats()
        {
            return base.Stats() + $", Breed: {Breed}";
        }
    }

  

}
