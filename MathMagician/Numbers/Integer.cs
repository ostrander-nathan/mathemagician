using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    interface Integer
    {
        int GetFirst(); // get first number
        int GetNext(int current); // get next int in sequence
        int[] GetSequence(int how_many); // get full sequence
        string PrintNumbers(int[] how_many); // print array of input
    }
}
