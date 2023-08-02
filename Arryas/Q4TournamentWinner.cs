using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arryas
{
    internal class Q4TournamentWinner
    {
        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {
                if (results[i] == 1)
                {
                    if (!dict.ContainsKey(competitions[i][0]))
                        dict.Add(competitions[i][0], 3);
                    else
                    {
                        int result = 0;
                        dict.TryGetValue(competitions[i][0], out result);
                        dict[competitions[i][0]] = result + 3;
                    }

                }
                else
                {
                    if (!dict.ContainsKey(competitions[i][1]))
                        dict.Add(competitions[i][1], 3);
                    else
                    {
                        int result = 0;
                        dict.TryGetValue(competitions[i][1], out result);
                        dict[competitions[i][1]] = result + 3;
                    }

                }


            }
            int max = 0;
            string Reultkey = "";

            foreach (KeyValuePair<string, int> key in dict)
            {
                if (key.Value > max)
                {
                    max = key.Value;
                    Reultkey = key.Key;
                }


            }
            return Reultkey;
        }

    }
}
