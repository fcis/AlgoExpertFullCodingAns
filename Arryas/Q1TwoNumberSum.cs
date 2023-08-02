using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arryas
{
    internal class Q1TwoNumberSum
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            Hashtable ht = new Hashtable();
            for (int i = 0; i < array.Length; i++)
            {
                ht.Add(i, array[i]);
            }
            ICollection Keys = ht.Keys;
            foreach (var key in Keys)
            {
                if (ht.ContainsValue(targetSum - Convert.ToInt32(ht[key])))
                {
                    return new int[] { Convert.ToInt32(ht[key]), targetSum - Convert.ToInt32(ht[key]) };
                }
            }
            return new int[0];
        }

    }
}
