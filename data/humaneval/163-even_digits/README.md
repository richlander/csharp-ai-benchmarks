# 163 -- Return even digits in given range

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
        /// Given two positive integers a and b, return the even digits between a
        /// and b, in ascending order.
        /// 
        /// For example:
        /// GenerateIntegers(2, 8) => [2, 4, 6, 8]
        /// GenerateIntegers(8, 2) => [2, 4, 6, 8]
        /// GenerateIntegers(10, 14) => []
        /// 
        /// </summary>
        public static List<int> GenerateIntegers (int a, int b) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = GenerateIntegers(2,10);
            var expected1 = new List<int> {2,4,6,8};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = GenerateIntegers(10,2);
            var expected2 = new List<int> {2,4,6,8};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = GenerateIntegers(132,2);
            var expected3 = new List<int> {2,4,6,8};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = GenerateIntegers(17,89);
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
