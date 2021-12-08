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

        public override void Show()
        {
            Console.WriteLine($"Reg.nr: {Kjennetegn}, {Kw}Kw effekt, Maksfart: {MaxSpeed} Farge: {Color}, Type: {Type}");
            Console.WriteLine($"Reg.nr: {Kjennetegn}, {Kw}Kw effekt, Maksfart: {MaxSpeed} Farge: {Color}, Type: {Type}");
        }
        public void Compare(Car bil2)
        {
            if (Kjennetegn == bil2.Kjennetegn)
            {
                Console.WriteLine("Bil 1 og Bil 2 er samme bilen");
            }
            else
            {
                Console.WriteLine("Bil 1 og Bil 2 er ikke samme bilen");
            }
        }
    }
}
