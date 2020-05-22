using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewKit_Cs
{
    class SherlockAndAnagrams
    {
        // Complete the twoStrings function below.
        static int sherlockAndAnagrams(string s)
        {
            var subList = from i in Enumerable.Range(0, s.Length)
                          from j in Enumerable.Range(0, s.Length - i + 1)
                          where j >= 1 select s.Substring(i, j);
            
            var key_freq = subList.Select(s => String.Concat(s.OrderBy(c => c)))
                           .GroupBy(k => k).ToDictionary(k => k.Key, k => k.Count());

            return key_freq.Values.Sum(x => x*(x-1)/2);
        }

        public static void Run(string[] args)
        {
            int q = 1;

            for (int qItr = 0; qItr < q; qItr++) {
                string s = "abba";

                int result = sherlockAndAnagrams(s);

                Console.WriteLine(result);
            }
        }
    }
}
