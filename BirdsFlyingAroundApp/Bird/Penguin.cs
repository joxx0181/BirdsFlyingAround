﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // This class represents penguin and implements a interface!
    public class Penguin : Bird, ISwim
    {
        // overriding method!
        public override void Draw()
        {
            Console.WriteLine("   ");
            Console.WriteLine("(o _");
            Console.WriteLine("(/ )");           
        }

        // The body of interface method is provided here!
        public string SwimSkill()
        {
            return "I can swim 3 to 6 miles per hour";
        }
    }
}
