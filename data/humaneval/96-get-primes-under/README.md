
# 96 -- Get primes less than a given non-negative integer

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
        /// Implement a function that takes an non-negative integer and returns an array of the first n
        /// integers that are prime numbers and less than n.
        /// for example:
        /// CountUpTo(5) => [2,3]
        /// CountUpTo(11) => [2,3,5,7]
        /// CountUpTo(0) => []
        /// CountUpTo(20) => [2,3,5,7,11,13,17,19]
        /// CountUpTo(1) => []
        /// CountUpTo(18) => [2,3,5,7,11,13,17]
        /// 
        /// </summary>
        public static List<int> CountUpTo (int n) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CountUpTo(5);
            var expected1 = new List<int> {2,3};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CountUpTo(6);
            var expected2 = new List<int> {2,3,5};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CountUpTo(7);
            var expected3 = new List<int> {2,3,5};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CountUpTo(10);
            var expected4 = new List<int> {2,3,5,7};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CountUpTo(0);
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = CountUpTo(22);
            var expected6 = new List<int> {2,3,5,7,11,13,17,19};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = CountUpTo(1);
            var expected7 = new List<int> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = CountUpTo(18);
            var expected8 = new List<int> {2,3,5,7,11,13,17};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = CountUpTo(47);
            var expected9 = new List<int> {2,3,5,7,11,13,17,19,23,29,31,37,41,43};
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = CountUpTo(101);
            var expected10 = new List<int> {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97};
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

        }
    }
}
```
