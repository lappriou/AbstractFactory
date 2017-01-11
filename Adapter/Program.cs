using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPiste PisteAvion = Adapter.AdapterPisteAvionIPiste(new PisteAvion());
            Boule boule = new Boule(PisteAvion);
        }
    }
}
