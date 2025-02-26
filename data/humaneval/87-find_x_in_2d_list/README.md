# 87 -- Find x in nested lists, return sorted coordinates

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
        /// You are given a 2 dimensional data, as a nested lists,
        /// which is similar to matrix, however, unlike matrices,
        /// each row may contain a different number of columns.
        /// Given lst, and integer x, find integers x in the list,
        /// and return list of tuples, [(x1, y1), (x2, y2) ...] such that
        /// each tuple is a coordinate - (row, columns), starting with 0.
        /// Sort coordinates initially by rows in ascending order.
        /// Also, sort coordinates of the row by columns in descending order.
        /// 
        /// Examples:
        /// GetRow([
        /// [1,2,3,4,5,6],
        /// [1,2,3,4,1,6],
        /// [1,2,3,4,5,1]
        /// ], 1) == [(0, 0), (1, 4), (1, 0), (2, 5), (2, 0)]
        /// GetRow([], 1) == []
        /// GetRow([[], [1], [1, 2, 3]], 3) == [(2, 2)]
        /// 
        /// </summary>
        public static List<List<int>> GetRow (List<List<int>> lst, int x) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected1 = new List<List<int>> {new List<int> {0,0},new List<int> {1,4},new List<int> {1,0},new List<int> {2,5},new List<int> {2,0}};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6}},2);
            var expected2 = new List<List<int>> {new List<int> {0,1},new List<int> {1,1},new List<int> {2,1},new List<int> {3,1},new List<int> {4,1},new List<int> {5,1}};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,1,3,4,5,6},new List<int> {1,2,1,4,5,6},new List<int> {1,2,3,1,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected3 = new List<List<int>> {new List<int> {0,0},new List<int> {1,0},new List<int> {2,1},new List<int> {2,0},new List<int> {3,2},new List<int> {3,0},new List<int> {4,3},new List<int> {4,0},new List<int> {5,4},new List<int> {5,0},new List<int> {6,5},new List<int> {6,0}};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = GetRow(new List<List<int>> {},1);
            var expected4 = new List<List<int>> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = GetRow(new List<List<int>> {new List<int> {1}},2);
            var expected5 = new List<List<int>> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = GetRow(new List<List<int>> {new List<int> {},new List<int> {1},new List<int> {1,2,3}},3);
            var expected6 = new List<List<int>> {new List<int> {2,2}};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
