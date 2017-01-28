using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class OddNumber: NaturalNumber
    {
        private int First { get; set; }

        public OddNumber()
        {
            First = 1;
        }

        public override int GetFirst()
        {
            return First;
        }

        public override int GetNext(int current)
        {
            return current + 2;
        }

      
    }
}
