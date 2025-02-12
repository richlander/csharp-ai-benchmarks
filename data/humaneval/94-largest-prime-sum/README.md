
# 94 -- Find largest prime and sum its digits

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
        /// You are given a list of integers.
        /// You need to find the largest prime value and return the sum of its digits.
        /// 
        /// Examples:
        /// For lst = [0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3] the output should be 10
        /// For lst = [1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1] the output should be 25
        /// For lst = [1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3] the output should be 13
        /// For lst = [0,724,32,71,99,32,6,0,5,91,83,0,5,6] the output should be 11
        /// For lst = [0,81,12,3,1,21] the output should be 3
        /// For lst = [0,8,1,2,1,7] the output should be 7
        /// 
        /// </summary>
        public static int Skjkasdkd (List<int> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Skjkasdkd(new List<int> {0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3});
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Skjkasdkd(new List<int> {1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Skjkasdkd(new List<int> {1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3});
            var expected3 = 13;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Skjkasdkd(new List<int> {0,724,32,71,99,32,6,0,5,91,83,0,5,6});
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Skjkasdkd(new List<int> {0,81,12,3,1,21});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Skjkasdkd(new List<int> {0,8,1,2,1,7});
            var expected6 = 7;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Skjkasdkd(new List<int> {8191});
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Skjkasdkd(new List<int> {8191,123456,127,7});
            var expected8 = 19;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = Skjkasdkd(new List<int> {127,97,8192});
            var expected9 = 10;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

        }
    }
}
```
