
# 110 -- Determine if lst1 can be made all even through exchange

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
        /// In this problem, you will implement a function that takes two lists of numbers,
        /// and determines whether it is possible to perform an Exchange of elements
        /// between them to make lst1 a list of only even numbers.
        /// There is no limit on the number of Exchanged elements between lst1 and lst2.
        /// If it is possible to Exchange elements between the lst1 and lst2 to make
        /// all the elements of lst1 to be even, return "YES".
        /// Otherwise, return "NO".
        /// For example:
        /// Exchange([1, 2, 3, 4], [1, 2, 3, 4]) => "YES"
        /// Exchange([1, 2, 3, 4], [1, 5, 3, 4]) => "NO"
        /// It is assumed that the input lists will be non-empty.
        /// 
        /// </summary>
        public static string Exchange (List<int> lst1, List<int> lst2) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Exchange(new List<int> {1,2,3,4},new List<int> {1,2,3,4});
            var expected1 = "YES";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Exchange(new List<int> {1,2,3,4},new List<int> {1,5,3,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Exchange(new List<int> {1,2,3,4},new List<int> {2,1,4,3});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Exchange(new List<int> {5,7,3},new List<int> {2,6,4});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Exchange(new List<int> {5,7,3},new List<int> {2,6,3});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Exchange(new List<int> {3,2,6,1,8,9},new List<int> {3,5,5,1,1,1});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Exchange(new List<int> {100,200},new List<int> {200,200});
            var expected7 = "YES";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
