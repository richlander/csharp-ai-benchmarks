
# 129 -- Find the minimum path of length k in a grid

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
        /// Given a grid with N rows and N columns (N >= 2) and a positive integer k, 
        /// each cell of the grid contains a value. Every integer in the range [1, N * N]
        /// inclusive appears exactly once on the cells of the grid.
        /// 
        /// You have to find the minimum path of length k in the grid. You can start
        /// from any cell, and in each step you can move to any of the neighbor cells,
        /// in other words, you can go to cells which share an edge with you current
        /// cell.
        /// Please note that a path of length k means visiting exactly k cells (not
        /// necessarily distinct).
        /// You CANNOT go off the grid.
        /// A path A (of length k) is considered less than a path B (of length k) if
        /// after making the ordered lists of the values on the cells that A and B go
        /// through (let's call them lst_A and lst_B), lst_A is lexicographically less
        /// than lst_B, in other words, there exist an integer index i (1 <= i <= k)
        /// such that lst_A[i] < lst_B[i] and for any j (1 <= j < i) we have
        /// lst_A[j] = lst_B[j].
        /// It is guaranteed that the answer is unique.
        /// Return an ordered list of the values on the cells that the minimum path go through.
        /// 
        /// Examples:
        /// 
        /// Input: grid = [ [1,2,3], [4,5,6], [7,8,9]], k = 3
        /// Output: [1, 2, 1]
        /// 
        /// Input: grid = [ [5,9,3], [4,1,6], [7,8,2]], k = 1
        /// Output: [1]
        /// 
        /// </summary>
        public static List<int> MinPath (List<List<int>> grid, int k) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MinPath(new List<List<int>> {new List<int> {1,2,3},new List<int> {4,5,6},new List<int> {7,8,9}},3);
            var expected1 = new List<int> {1,2,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MinPath(new List<List<int>> {new List<int> {5,9,3},new List<int> {4,1,6},new List<int> {7,8,2}},1);
            var expected2 = new List<int> {1};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = MinPath(new List<List<int>> {new List<int> {1,2,3,4},new List<int> {5,6,7,8},new List<int> {9,10,11,12},new List<int> {13,14,15,16}},4);
            var expected3 = new List<int> {1,2,1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = MinPath(new List<List<int>> {new List<int> {6,4,13,10},new List<int> {5,7,12,1},new List<int> {3,16,11,15},new List<int> {8,14,9,2}},7);
            var expected4 = new List<int> {1,10,1,10,1,10,1};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = MinPath(new List<List<int>> {new List<int> {8,14,9,2},new List<int> {6,4,13,15},new List<int> {5,7,1,12},new List<int> {3,10,11,16}},5);
            var expected5 = new List<int> {1,7,1,7,1};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = MinPath(new List<List<int>> {new List<int> {11,8,7,2},new List<int> {5,16,14,4},new List<int> {9,3,15,6},new List<int> {12,13,10,1}},9);
            var expected6 = new List<int> {1,6,1,6,1,6,1,6,1};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = MinPath(new List<List<int>> {new List<int> {12,13,10,1},new List<int> {9,3,15,6},new List<int> {5,16,14,4},new List<int> {11,8,7,2}},12);
            var expected7 = new List<int> {1,6,1,6,1,6,1,6,1,6,1,6};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = MinPath(new List<List<int>> {new List<int> {2,7,4},new List<int> {3,1,5},new List<int> {6,8,9}},8);
            var expected8 = new List<int> {1,3,1,3,1,3,1,3};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = MinPath(new List<List<int>> {new List<int> {6,1,5},new List<int> {3,8,9},new List<int> {2,7,4}},8);
            var expected9 = new List<int> {1,5,1,5,1,5,1,5};
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = MinPath(new List<List<int>> {new List<int> {1,2},new List<int> {3,4}},10);
            var expected10 = new List<int> {1,2,1,2,1,2,1,2,1,2};
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = MinPath(new List<List<int>> {new List<int> {1,3},new List<int> {3,2}},10);
            var expected11 = new List<int> {1,3,1,3,1,3,1,3,1,3};
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

        }
    }
}
```
