using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> bird = new List<Bird>()
            {
                new Duck(),
                new Owl(),
                new Penguin(),
                new Ostrich()
            };

            foreach (Bird b in bird)
            {
                Console.WriteLine("\n" + b);
                b.Draw();

                if (b is IFly) 
                {
                    ((IFly)b).SetAltitude(1.1);
                    ((IFly)b).SetLocation(2.2, 3.3);
                }

                if (b is Duck d) {
                    Console.WriteLine(d.FlySkill() + "\n" + d.SwimSkill());
                }
                if (b is Owl o) {
                    Console.WriteLine(o.FlySkill() + "\n" + o.SwimSkill());
                }
                if (b is Penguin p) {
                    Console.WriteLine(p.SwimSkill());
                }
             }
            Console.ReadKey();
        }
    }
}


