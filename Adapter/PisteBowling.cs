using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PisteBowling : IPiste
    {

        public int Largeur { get; set; }
        public int Hauteur { get; set; }

        public int getLargeur()
        {
            return Largeur;
        }

        public int getHauteur()
        {
            return Hauteur;
        }



        public PisteBowling(int largeur, int hauteur)
        {
            this.Hauteur = hauteur;
            this.Largeur = largeur;

        }
    }
}
