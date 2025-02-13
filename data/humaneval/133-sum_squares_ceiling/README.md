# 133 -- Sum of ceiling-squared numbers in a list

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
        /// You are given a list of numbers.
        /// You need to return the sum of squared numbers in the given list,
        /// round each element in the list to the upper int(Ceiling) first.
        /// Examples:
        /// For lst = [1,2,3] the output should be 14
        /// For lst = [1,4,9] the output should be 98
        /// For lst = [1,3,5,7] the output should be 84
        /// For lst = [1.4,4.2,0] the output should be 29
        /// For lst = [-2.4,1,1] the output should be 6
        /// 
        /// 
        /// 
        /// </summary>
        public static int SumSquares (List<object> lst) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SumSquares(new List<object> {1,2,3});
            var expected1 = 14;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SumSquares(new List<object> {1.0,2,3});
            var expected2 = 14;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SumSquares(new List<object> {1,3,5,7});
            var expected3 = 84;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SumSquares(new List<object> {1.4,4.2,0});
            var expected4 = 29;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SumSquares(new List<object> {-2.4,1,1});
            var expected5 = 6;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SumSquares(new List<object> {100,1,15,2});
            var expected6 = 10230;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SumSquares(new List<object> {10000,10000});
            var expected7 = 200000000;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = SumSquares(new List<object> {-1.4,4.6,6.3});
            var expected8 = 75;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = SumSquares(new List<object> {-1.4,17.9,18.9,19.9});
            var expected9 = 1086;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = SumSquares(new List<object> {0});
            var expected10 = 0;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = SumSquares(new List<object> {-1});
            var expected11 = 1;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = SumSquares(new List<object> {-1,1,0});
            var expected12 = 2;
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

        }
    }
}
```
