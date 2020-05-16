using System.IO;
using System;
using System.Collections.Generic;

namespace InterviewKit_Cs
{
    class TwoStrings
    {
        // Complete the twoStrings function below.
        static string twoStrings(string s1, string s2)
        {
            var set1 = new HashSet<char>(s1);
            var set2 = new HashSet<char>(s2);
            set1.IntersectWith(set2);
            return set1.Count == 0 ? "NO" : "YES";
        }

        public static void Run(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = 1;

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 ="hello";

                string s2 = "world";

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);

                //textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
