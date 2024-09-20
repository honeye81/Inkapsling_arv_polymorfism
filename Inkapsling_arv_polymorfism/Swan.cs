using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_arv_polymorfism
{
    public class Swan : Bird
    {
        public Swan(string name, double weight, int age, double wingSpan) : base(name, weight, age, wingSpan)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Honk!");
        }
    }
}
