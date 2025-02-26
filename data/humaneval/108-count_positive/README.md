# 108 -- Function counts numbers with digit sum > 0

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
        /// Write a function CountNums which takes an array of integers and returns
        /// the number of elements which has a sum of digits > 0.
        /// If a number is negative, then its first signed digit will be negative:
        /// e.g. -123 has signed digits -1, 2, and 3.
        /// >>> CountNums([]) == 0
        /// >>> CountNums([-1, 11, -11]) == 1
        /// >>> CountNums([1, 1, 2]) == 3
        /// 
        /// </summary>
        public static int CountNums (List<int> arr) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CountNums(new List<int> {});
            var expected1 = 0;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CountNums(new List<int> {-1,-2,0});
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CountNums(new List<int> {1,1,2,-2,3,4,5});
            var expected3 = 6;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CountNums(new List<int> {1,6,9,-6,0,1,5});
            var expected4 = 5;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CountNums(new List<int> {1,100,98,-7,1,-1});
            var expected5 = 4;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = CountNums(new List<int> {12,23,34,-45,-56,0});
            var expected6 = 5;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = CountNums(new List<int> {0,1});
            var expected7 = 1;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = CountNums(new List<int> {1});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
