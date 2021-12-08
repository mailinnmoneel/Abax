using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{   
    abstract public class Transport
    {
        public string TransportType;
        public string Kjennetegn;
        public int Kw;


        public Transport(string kjennetegn, int kw, string transportType)
        {
            Kjennetegn = kjennetegn;
            Kw = kw;
            TransportType = transportType;
        }

        public string Run(string TransportType)
        {
              return $"{TransportType} is moving";
        }

        public abstract void Show();
    }
}
