
# 114 -- Find the minimum sum of any sub-array in nums

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
        /// Given an array of integers nums, find the minimum sum of any non-empty sub-array
        /// of nums.
        /// Example
        /// MinSubArraySum([2, 3, 4, 1, 2, 4]) == 1
        /// MinSubArraySum([-1, -2, -3]) == -6
        /// 
        /// </summary>
        public static int MinSubArraySum (List<int> nums) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MinSubArraySum(new List<int> {2,3,4,1,2,4});
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MinSubArraySum(new List<int> {-1,-2,-3});
            var expected2 = -6;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = MinSubArraySum(new List<int> {-1,-2,-3,2,-10});
            var expected3 = -14;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = MinSubArraySum(new List<int> {-9999999999999999});
            var expected4 = -9999999999999999;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = MinSubArraySum(new List<int> {0,10,20,1000000});
            var expected5 = 0;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = MinSubArraySum(new List<int> {-1,-2,-3,10,-5});
            var expected6 = -6;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = MinSubArraySum(new List<int> {100,-1,-2,-3,10,-5});
            var expected7 = -6;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = MinSubArraySum(new List<int> {10,11,13,8,3,4});
            var expected8 = 3;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = MinSubArraySum(new List<int> {100,-33,32,-1,0,-2});
            var expected9 = -33;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = MinSubArraySum(new List<int> {-10});
            var expected10 = -10;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = MinSubArraySum(new List<int> {7});
            var expected11 = 7;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = MinSubArraySum(new List<int> {1,-1});
            var expected12 = -1;
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

        }
    }
}
```
