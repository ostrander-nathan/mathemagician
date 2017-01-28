using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
       
        private int First { get; set; }

        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;
        }
        
        public virtual int GetFirst()
        {
            return First;
        }
    
        public virtual int GetNext(int current)
        {
            return current + 1;
        }

        public virtual int[] GetSequence(int how_many)
        {
            int[] seqCounter;
            seqCounter = new int[how_many];
            seqCounter[0] = GetFirst();

            for (int i = 1; i < seqCounter.Length; i++)
            {
             // seqCounter[i] = i+1;
              seqCounter[i] = GetNext(seqCounter[i - 1]);
              
            }
            return seqCounter;
        }

        public string PrintNumbers(int[] how_many)
        {
            //return String.Join(" ", how_many);
            String entireNumber = string.Join(" ", how_many);
            return entireNumber;
        }
        
    }
}
