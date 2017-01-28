using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
   public class EvenNumber : NaturalNumber
    {
        private int First { get; set; }

        public EvenNumber()
        {
            First = 2;
        }

        public override int GetFirst()
        {
            return First;
        }

        public override int GetNext(int current)
        {
            return current + 2;
        }

        public override int[] GetSequence(int how_many)
        {
            int[] seqCounter;
            seqCounter = new int[how_many];

            for (int i = 0; i < seqCounter.Length; i++)
            {
                seqCounter[i] = i * 2;
            }
            return seqCounter;
        }
    }
}
