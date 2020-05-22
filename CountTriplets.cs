using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class CountTriplets {

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r) {
        var potentialTwoTuples = new Dictionary<long, long>();
        var potentialThreeTuples = new Dictionary<long, long>();
        long count = 0;
        foreach (var key in arr)
        {
            count += potentialThreeTuples.TryGetValue(key, out var tmp) ? tmp : 0;
            
            if (potentialThreeTuples.ContainsKey(key * r))
            {
                potentialThreeTuples[key * r] += potentialTwoTuples.TryGetValue(key, out tmp) ? tmp : 0;
            }
            else
            {
                potentialThreeTuples.Add(key * r, potentialTwoTuples.TryGetValue(key, out tmp) ? tmp : 0);
            }

            if (potentialTwoTuples.ContainsKey(key * r))
            {
                potentialTwoTuples[key * r] += 1;
            }
            else
            {
                potentialTwoTuples.Add(key * r, 1);
            }
        }
        return count;
    }

    public static void Run(string[] args) {
        //int n = 4;

        long r = 3;

        List<long> arr = new List<long> {1, 1, 3, 9, 27, 81};

        long ans = countTriplets(arr, r);
        
        Console.WriteLine(ans);
    }
}
