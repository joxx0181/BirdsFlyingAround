using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // This class represents duck and implements interfaces!
    public class Duck : Bird, IFly, ISwim
    {
        // overriding method!
        public override void Draw()
        {
            Console.WriteLine("  __");
            Console.WriteLine("<(o )__");
            Console.WriteLine(" (____/");
        }

        // The body of interface methods is provided here!
        public void SetAltitude(double altitude)
        {
            //SetAltitude
        }

        public void SetLocation(double longitude, double latitude)
        {
            //SetLocation
        }
        public string FlySkill()
        {
            return "I can fly at a speed of about 67km / h";
        }
        public string SwimSkill()
        {
            return "I can swim and I do it every day";
        }
    }
}
