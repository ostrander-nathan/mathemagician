using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
       protected int First { get; set; } // protected allows the children to inherit but private to outside
       protected int Step { get; set; }

        public NaturalNumber()
        {
            // Both lines 17 & 18 the same Sugar Example
            First++;
            //First = 1;
            Step = 1;
            // this.First = 1;
        }

        public virtual int GetFirst() => First;
        //{ EXAMPLE OF SYNTACTIC SUGAR
        //    return First;
        //}

        public virtual int GetNext(int current) => current + Step;
        //{ ANOTHER SYNTACTIC SUGAR EXAMPLE
        //    return current + Step;
        //}

        public virtual int[] GetSequence(int how_many)
        {
            int[] seqCounter;
            seqCounter = new int[how_many];
            seqCounter[0] = GetFirst();

            for (int i = 1; i < seqCounter.Length; i++) 
            {
              seqCounter[i] = GetNext(seqCounter[i - 1]);
            }
            return seqCounter;
        }

        public string PrintNumbers(int[] how_many)
        {
            string entireNumber = string.Join(" ", how_many);
            return entireNumber;
        }
    }
}
