using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // This class represents owl and implements interfaces!
    public class Owl : Bird, IFly, ISwim
    {
        // overriding methods!
        public override void Draw()
        {
            Console.WriteLine(" ,_,");
            Console.WriteLine("(O,O)");
            Console.WriteLine("(   )");
            Console.WriteLine(" ¨ ¨ ");
        }

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
            return "I can fly at a speed of about 65km / h";
        }
        public string SwimSkill()
        {
            return "I can swim but do it rarely";
        }
    }
}
