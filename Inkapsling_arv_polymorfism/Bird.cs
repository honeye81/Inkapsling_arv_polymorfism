﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_arv_polymorfism
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp!");
        }

        public override string Stats()
        {
            return base.Stats() + $", WingSpan: {WingSpan} meters";
        }
    }
}
