using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication {
    class Program {
        static void Main(string[] args) {
            MaBibliotheque.Bonjour bonjour = new MaBibliotheque.Bonjour();
            bonjour.DireBonjour();

            // Nuget
            for (int i = 0; i < 10000; i++) {
                if (AForge.Math.Tools.IsPowerOf2(i))
                    Console.WriteLine(i + " est une puissance de 2");
            }
        }
    }
}
