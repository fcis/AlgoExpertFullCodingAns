using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arryas
{
    internal class Q2ValidateSubsequent
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            //List<int> arr1 = new List<int> { 5, 22, 1, 25, 6, -1, 8, 10 };
            //List<int> arr2 = new List<int> { 1, 6, -1, 10 };
            int sIndex = 0;
            for (int i = 0; i < array.Count && sIndex != sequence.Count; i++)
            {
                if (array[i] == sequence[sIndex])
                    sIndex++;
            }
            return sIndex == sequence.Count;
        }

    }
}
