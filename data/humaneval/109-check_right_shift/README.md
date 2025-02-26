# 109 -- Determine if array can be sorted via right shifts

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
        /// We have an array 'arr' of N integers arr[1], arr[2], ..., arr[N].The
        /// numbers in the array will be randomly ordered. Your task is to determine if
        /// it is possible to get an array sorted in non-decreasing order by performing 
        /// the following operation on the given array:
        /// You are allowed to perform right shift operation any number of times.
        /// 
        /// One right shift operation means shifting all elements of the array by one
        /// position in the right direction. The last element of the array will be moved to
        /// the starting position in the array i.e. 0th index. 
        /// 
        /// If it is possible to obtain the sorted array by performing the above operation
        /// then return True else return False.
        /// If the given array is empty then return True.
        /// 
        /// Note: The given list is guaranteed to have unique elements.
        /// 
        /// For Example:
        /// 
        /// MoveOneBall([3, 4, 5, 1, 2])==>True
        /// Explanation: By performin 2 right shift operations, non-decreasing order can
        /// be achieved for the given array.
        /// MoveOneBall([3, 5, 4, 1, 2])==>False
        /// Explanation:It is not possible to get non-decreasing order for the given
        /// array by performing any number of right shift operations.
        /// 
        /// 
        /// </summary>
        public static bool MoveOneBall (List<int> arr) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MoveOneBall(new List<int> {3,4,5,1,2});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MoveOneBall(new List<int> {3,5,10,1,2});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = MoveOneBall(new List<int> {4,3,1,2});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = MoveOneBall(new List<int> {3,5,4,1,2});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = MoveOneBall(new List<int> {});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
