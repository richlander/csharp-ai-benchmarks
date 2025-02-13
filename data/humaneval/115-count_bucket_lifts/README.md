# 115 -- Count bucket uses to empty water wells

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
        /// You are given a rectangular grid of wells. Each row represents a single well,
        /// and each 1 in a row represents a single unit of water.
        /// Each well has a corresponding bucket that can be used to extract water from it, 
        /// and all buckets have the same capacity.
        /// Your task is to use the buckets to empty the wells.
        /// Output the number of times you need to lower the buckets.
        /// 
        /// Example 1:
        /// Input: 
        /// grid : [[0,0,1,0], [0,1,0,0], [1,1,1,1]]
        /// bucket_capacity : 1
        /// Output: 6
        /// 
        /// Example 2:
        /// Input: 
        /// grid : [[0,0,1,1], [0,0,0,0], [1,1,1,1], [0,1,1,1]]
        /// bucket_capacity : 2
        /// Output: 5
        /// 
        /// Example 3:
        /// Input: 
        /// grid : [[0,0,0], [0,0,0]]
        /// bucket_capacity : 5
        /// Output: 0
        /// 
        /// Constraints:
        /// * all wells have the same length
        /// * 1 <= grid.length <= 10^2
        /// * 1 <= grid[:,1].length <= 10^2
        /// * grid[i][j] -> 0 | 1
        /// * 1 <= capacity <= 10
        /// 
        /// </summary>
        public static int MaxFill (List<List<int>> grid, int capacity) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MaxFill(new List<List<int>> {new List<int> {0,0,1,0},new List<int> {0,1,0,0},new List<int> {1,1,1,1}},1);
            var expected1 = 6;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MaxFill(new List<List<int>> {new List<int> {0,0,1,1},new List<int> {0,0,0,0},new List<int> {1,1,1,1},new List<int> {0,1,1,1}},2);
            var expected2 = 5;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = MaxFill(new List<List<int>> {new List<int> {0,0,0},new List<int> {0,0,0}},5);
            var expected3 = 0;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = MaxFill(new List<List<int>> {new List<int> {1,1,1,1},new List<int> {1,1,1,1}},2);
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = MaxFill(new List<List<int>> {new List<int> {1,1,1,1},new List<int> {1,1,1,1}},9);
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
