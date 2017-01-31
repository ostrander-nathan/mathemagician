using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        //private int[] BaseSequence { get; set; }
        
        public int GetNextFib(int currentNumber, int previousNumber)
        {
            return currentNumber + previousNumber;
        }

        public override int[] GetSequence(int how_many)
        {
            int[] fibonacciNumber = new int[how_many]; // sets int[how_many] to fibonacciNumber
            fibonacciNumber[0] = GetFirst();// sets first position to 0 

            if (how_many >= 2)
            {
                fibonacciNumber[1] = 1;// sets second array position to 1
            }

            for (int i = 2; i < how_many; i++)
            {
                fibonacciNumber[i] = fibonacciNumber[i - 1] + fibonacciNumber[i - 2];//  F{n}=F{n-1}+F{n-2}
            }
            return fibonacciNumber;
        }
    }
 }


