using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributs {
    class Program {
        static void Main(string[] args) {
            AttributeClass ac = new AttributeClass();
            ac.OldMathod();
            ac.NewMathod();

            SpecialClass sc = new SpecialClass(1, "a");
        }
    }
}
