using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorewood.Personnages
{
    class Hero : Personnage
    {
        public Hero(string nom, int end, int forc, int pv, int modifend, int modifforc) : base(nom, end, forc, pv, modifend, modifforc)
        {
        }
    }
}
