using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributs {
    public class AttributeClass {
        [Obsolete("ma classe est obselete")]
        public void OldMathod() {
            Console.WriteLine("catch me if you can");
        }

        [MyCustomAttribute(true, 7)]
        public void NewMathod() {
            Console.WriteLine("u caught me");
        }

        [SpecialClass(1, "a")]
        public class ClassSthg {
        }

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class SpecialClass : Attribute {
        public SpecialClass(int a, string b) {

        }
    }
}

