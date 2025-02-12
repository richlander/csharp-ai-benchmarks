
# 68 -- Find the smallest even node value and its index

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
        /// "Given an array representing a branch of a tree that has non-negative integer nodes
        /// your task is to Pluck one of the nodes and return it.
        /// The Plucked node should be the node with the smallest even value.
        /// If multiple nodes with the same smallest even value are found return the node that has smallest index.
        /// 
        /// The Plucked node should be returned in a list, [ smalest_value, its index ],
        /// If there are no even values or the given array is empty, return [].
        /// 
        /// Example 1:
        /// Input: [4,2,3]
        /// Output: [2, 1]
        /// Explanation: 2 has the smallest even value, and 2 has the smallest index.
        /// 
        /// Example 2:
        /// Input: [1,2,3]
        /// Output: [2, 1]
        /// Explanation: 2 has the smallest even value, and 2 has the smallest index. 
        /// 
        /// Example 3:
        /// Input: []
        /// Output: []
        /// 
        /// Example 4:
        /// Input: [5, 0, 3, 0, 4, 2]
        /// Output: [0, 1]
        /// Explanation: 0 is the smallest value, but  there are two zeros,
        /// so we will choose the first zero, which has the smallest index.
        /// 
        /// Constraints:
        /// * 1 <= nodes.length <= 10000
        /// * 0 <= node.value
        /// 
        /// </summary>
        public static List<int> Pluck (List<int> arr) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Pluck(new List<int> {4,2,3});
            var expected1 = new List<int> {2,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Pluck(new List<int> {1,2,3});
            var expected2 = new List<int> {2,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Pluck(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Pluck(new List<int> {5,0,3,0,4,2});
            var expected4 = new List<int> {0,1};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Pluck(new List<int> {1,2,3,0,5,3});
            var expected5 = new List<int> {0,3};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Pluck(new List<int> {5,4,8,4,8});
            var expected6 = new List<int> {4,1};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Pluck(new List<int> {7,6,7,1});
            var expected7 = new List<int> {6,1};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Pluck(new List<int> {7,9,7,1});
            var expected8 = new List<int> {};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
