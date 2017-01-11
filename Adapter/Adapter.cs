using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    static class Adapter
    {

        static public IPiste AdapterPisteAvionIPiste(PisteAvion Piste)
        {
            return new PisteBowling(Piste.getLongueur()*2, Piste.getLargeur()*2);

        }
    }
}
