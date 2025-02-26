# 155 -- Count even and odd digits in integer

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
        /// Given an integer. return a tuple that has the number of even and odd digits respectively.
        /// 
        /// Example:
        /// EvenOddCount(-12) ==> (1, 1)
        /// EvenOddCount(123) ==> (1, 2)
        /// 
        /// </summary>
        public static List<int> EvenOddCount (int num) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = EvenOddCount(7);
            var expected1 = new List<int> {0,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = EvenOddCount(-78);
            var expected2 = new List<int> {1,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = EvenOddCount(3452);
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = EvenOddCount(346211);
            var expected4 = new List<int> {3,3};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = EvenOddCount(-345821);
            var expected5 = new List<int> {3,3};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = EvenOddCount(-2);
            var expected6 = new List<int> {1,0};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = EvenOddCount(-45347);
            var expected7 = new List<int> {2,3};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = EvenOddCount(0);
            var expected8 = new List<int> {1,0};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
