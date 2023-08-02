using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arryas
{
    internal class Q3SortedSquaredArray
    {
        public static int[] SortedSquaredArray(int[] array)
        {
            // Write your code here.

            var res = new int[array.Length];
            var maxElemnt = array.Length - 1;
            var lowElement = 0;


            for (int i = array.Length - 1; i >= lowElement; i--)
            {

                if (Math.Abs(array[maxElemnt]) >= Math.Abs(array[lowElement]))
                {
                    res[i] = Convert.ToInt32(Math.Pow(array[maxElemnt], 2));
                    maxElemnt--;
                }
                else if (Math.Abs(array[maxElemnt]) < Math.Abs(array[lowElement]))
                {
                    res[i] = Convert.ToInt32(Math.Pow(array[lowElement], 2));
                    lowElement++;
                }


            }
            return res;

        }

    }
}
