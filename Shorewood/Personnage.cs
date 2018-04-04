using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = Shorewood;

namespace Shorewood
{
    class Personnage
    {
        public string Nom { get; set; }
        public int End { get; set; }
        public int Forc { get; set; }
        public int PV { get; set; }       
        public int ModifEnd { get; set; }
        public int ModifForc { get; set; }

        public Personnage(string nom, int end, int forc, int pv, int modifend,  int modifforc)
        {
            Nom = nom;
            End = end;
            Forc = forc;
            PV = pv;            
            ModifEnd = modifend;
            ModifForc = modifforc;
        }


        private static Random rand = new Random();

        public int CalculEnd()
        {
            int Lancer = 0;
            for (int i = 0; i < 4; i++)
            {
                Lancer = rand.Next(1, 7);
                End = End+Lancer;
            }
            return End;
        }
        public int CalculeFor()
        {
            int Lancer = 0;
            for (int i = 0; i < 4; i++)
            {
                Lancer = rand.Next(1, 7);
                Forc = Forc+Lancer;
            }
            return Forc;
        }

        public int CalculePV()
        {
            PV = Forc + ModifEnd;
            return PV;
        }

        public int actionFrappe()
        {
            int action = 0;
            for (int i = 0; i < 4; i++)
            {
                action = rand.Next(1, 4);
                ModifForc = ModifForc - action;
            }
            return ModifForc;
        }

    }
}
