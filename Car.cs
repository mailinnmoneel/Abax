using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    class Car : Transport
    {
        public int MaxSpeed;
        public string Color;
        public string Type;
        public Car(string kjennetegn, int kw, string transportType, int maxspeed, string color, string type) : base(kjennetegn, kw, transportType)
        {
            MaxSpeed = maxspeed;
            Color = color;
            Type = type;
        }
    }
}
