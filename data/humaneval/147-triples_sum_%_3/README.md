# 147 -- Count triples where sum is multiple of 3

## Prompt

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using KellermanSoftware.CompareNetObjects;

namespace Solution
{
    public class Program
    {
        /// <summary> 
        /// You're an expert C# programmer
        /// 
        /// You are given a positive integer n. You have to create an integer array a of length n.
        /// For each i (1 ≤ i ≤ n), the value of a[i] = i * i - i + 1.
        /// Return the number of triples (a[i], a[j], a[k]) of a where i < j < k, 
        /// and a[i] + a[j] + a[k] is a multiple of 3.
        /// 
        /// Example :
        /// Input: n = 5
        /// Output: 1
        /// Explanation: 
        /// a = [1, 3, 7, 13, 21]
        /// The only valid triple is (1, 7, 13).
        /// 
        /// </summary>
        public static int GetMaxTriples (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = GetMaxTriples(5);
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = GetMaxTriples(6);
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = GetMaxTriples(10);
            var expected3 = 36;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = GetMaxTriples(100);
            var expected4 = 53361;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
