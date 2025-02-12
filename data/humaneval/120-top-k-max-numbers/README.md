
# 120 -- Get the top k maximum numbers from an integer array

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
        /// Given an array arr of integers and a positive integer k, return a sorted list 
        /// of length k with the Maximum k numbers in arr.
        /// 
        /// Example 1:
        /// 
        /// Input: arr = [-3, -4, 5], k = 3
        /// Output: [-4, -3, 5]
        /// 
        /// Example 2:
        /// 
        /// Input: arr = [4, -4, 4], k = 2
        /// Output: [4, 4]
        /// 
        /// Example 3:
        /// 
        /// Input: arr = [-3, 2, 1, 2, -1, -2, 1], k = 1
        /// Output: [2]
        /// 
        /// Note:
        /// 1. The length of the array will be in the range of [1, 1000].
        /// 2. The elements in the array will be in the range of [-1000, 1000].
        /// 3. 0 <= k <= len(arr)
        /// 
        /// </summary>
        public static List<int> Maximum (List<int> arr, int k) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Maximum(new List<int> {-3,-4,5},3);
            var expected1 = new List<int> {-4,-3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Maximum(new List<int> {4,-4,4},2);
            var expected2 = new List<int> {4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Maximum(new List<int> {-3,2,1,2,-1,-2,1},1);
            var expected3 = new List<int> {2};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Maximum(new List<int> {123,-123,20,0,1,2,-3},3);
            var expected4 = new List<int> {2,20,123};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Maximum(new List<int> {-123,20,0,1,2,-3},4);
            var expected5 = new List<int> {0,1,2,20};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Maximum(new List<int> {5,15,0,3,-13,-8,0},7);
            var expected6 = new List<int> {-13,-8,0,0,3,5,15};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Maximum(new List<int> {-1,0,2,5,3,-10},2);
            var expected7 = new List<int> {3,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Maximum(new List<int> {1,0,5,-7},1);
            var expected8 = new List<int> {5};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = Maximum(new List<int> {4,-4},2);
            var expected9 = new List<int> {-4,4};
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = Maximum(new List<int> {-10,10},2);
            var expected10 = new List<int> {-10,10};
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = Maximum(new List<int> {1,2,3,-23,243,-400,0},0);
            var expected11 = new List<int> {};
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

        }
    }
}
```
