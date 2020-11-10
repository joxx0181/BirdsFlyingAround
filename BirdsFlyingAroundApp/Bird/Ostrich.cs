using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // This class represents bird
    public class Ostrich : Bird
    {
        // overriding method!
        public override void Draw()
        {
            Console.WriteLine("    ");
            Console.WriteLine("< o) ");
            Console.WriteLine(" ||___");
            Console.WriteLine("(____/");
            Console.WriteLine("  || ");
        }
    }
}
    
 