using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    class Plane : Transport
    {
       
       public int Vingespenn;
       public int Lasteevne;
       public int Egenvekt;
       public string Type;
       public Plane(string kjennetegn, int kw, string transportType, int vingespenn, int lasteevne,int egenvekt, string type) : base(kjennetegn, kw, transportType)
       {
           Vingespenn = vingespenn;
           Lasteevne = lasteevne;
           Egenvekt = egenvekt;
           Type = type;
       }

       public override void Show()
       {
           Console.WriteLine($"Reg.nr: {Kjennetegn}, {Kw}Kw effekt, Vingespenn: {Vingespenn}, Lasteevne: {Lasteevne}, Egenvekt: {Egenvekt}, Type: {Type}");
        }
    }
}
