using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    // This interface represents fly!
    interface IFly
    {
        // abstract methods with empty bodies!
        void SetLocation(double longitude, double latitude);
        void SetAltitude(double altitude);

        string FlySkill();
    }
}
