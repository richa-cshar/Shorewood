using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = Shorewood;
using Shorewood.Core;
using Shorewood.Personnages.Héros;

namespace Shorewood
{
    class Program
    {
        static void Main(string[] args)
        {
            Humain h = new Humain();
            h.Nom = "Pago";
            h.PV = 5;
            h.Forc = 120;
            h.End = 150;

            Console.WriteLine($"Je suis {h.Nom}");
            Console.ReadLine();
        }
    }
}
