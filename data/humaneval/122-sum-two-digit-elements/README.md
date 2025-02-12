
# 122 -- Sum elements with ≤2 digits from first k elements

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
        /// Given a non-empty array of integers arr and an integer k, return
        /// the sum of the elements with at most two digits from the first k elements of arr.
        /// 
        /// Example:
        /// 
        /// Input: arr = [111,21,3,4000,5,6,7,8,9], k = 4
        /// Output: 24 # sum of 21 + 3
        /// 
        /// Constraints:
        /// 1. 1 <= len(arr) <= 100
        /// 2. 1 <= k <= len(arr)
        /// 
        /// </summary>
        public static int AddElements (List<int> arr, int k) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = AddElements(new List<int> {1,-2,-3,41,57,76,87,88,99},3);
            var expected1 = -4;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = AddElements(new List<int> {111,121,3,4000,5,6},2);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = AddElements(new List<int> {11,21,3,90,5,6,7,8,9},4);
            var expected3 = 125;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = AddElements(new List<int> {111,21,3,4000,5,6,7,8,9},4);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = AddElements(new List<int> {1},1);
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
