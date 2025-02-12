
# 121 -- Sum of odd elements at even positions

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
        /// Given a non-empty list of integers, return the sum of all of the odd elements that are in even positions.
        /// 
        /// 
        /// Examples
        /// Solution([5, 8, 7, 1]) ==> 12
        /// Solution([3, 3, 3, 3, 3]) ==> 9
        /// Solution([30, 13, 24, 321]) ==>0
        /// 
        /// </summary>
        public static int Solution (List<int> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Solution(new List<int> {5,8,7,1});
            var expected1 = 12;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Solution(new List<int> {3,3,3,3,3});
            var expected2 = 9;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Solution(new List<int> {30,13,24,321});
            var expected3 = 0;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Solution(new List<int> {5,9});
            var expected4 = 5;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Solution(new List<int> {2,4,8});
            var expected5 = 0;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Solution(new List<int> {30,13,23,32});
            var expected6 = 23;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Solution(new List<int> {3,13,2,9});
            var expected7 = 3;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
