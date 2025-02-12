
# 142 -- Sum Squares

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
        /// </summary>
        public static int SumSquares (List<int> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SumSquares(new List<int> {1,2,3});
            var expected1 = 6;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SumSquares(new List<int> {1,4,9});
            var expected2 = 14;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SumSquares(new List<int> {});
            var expected3 = 0;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SumSquares(new List<int> {1,1,1,1,1,1,1,1,1});
            var expected4 = 9;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SumSquares(new List<int> {-1,-1,-1,-1,-1,-1,-1,-1,-1});
            var expected5 = -3;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SumSquares(new List<int> {0});
            var expected6 = 0;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SumSquares(new List<int> {-1,-5,2,-1,-5});
            var expected7 = -126;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = SumSquares(new List<int> {-56,-99,1,0,-2});
            var expected8 = 3030;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = SumSquares(new List<int> {-1,0,0,0,0,0,0,0,-1});
            var expected9 = 0;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = SumSquares(new List<int> {-16,-9,-2,36,36,26,-20,25,-40,20,-4,12,-26,35,37});
            var expected10 = -14196;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = SumSquares(new List<int> {-1,-3,17,-1,-15,13,-1,14,-14,-12,-5,14,-14,6,13,11,16,16,4,10});
            var expected11 = -1448;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

        }
    }
}
```
