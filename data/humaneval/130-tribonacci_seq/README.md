# 130 -- Introduction to the Tribonacci sequence

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
        /// Everyone knows Fibonacci sequence, it was studied deeply by mathematicians in 
        /// the last couple centuries. However, what people don't know is Tribonacci sequence.
        /// Tribonacci sequence is defined by the recurrence:
        /// Tri(1) = 3
        /// Tri(n) = 1 + n / 2, if n is even.
        /// Tri(n) =  Tri(n - 1) + Tri(n - 2) + Tri(n + 1), if n is odd.
        /// For example:
        /// Tri(2) = 1 + (2 / 2) = 2
        /// Tri(4) = 3
        /// Tri(3) = Tri(2) + Tri(1) + Tri(4)
        /// = 2 + 3 + 3 = 8 
        /// You are given a non-negative integer number n, you have to a return a list of the 
        /// first n + 1 numbers of the Tribonacci sequence.
        /// Examples:
        /// Tri(3) = [1, 3, 2, 8]
        /// 
        /// </summary>
        public static List<object> Tri (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Tri(3);
            var expected1 = new List<object> {1,3,2.0,8.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Tri(4);
            var expected2 = new List<object> {1,3,2.0,8.0,3.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Tri(5);
            var expected3 = new List<object> {1,3,2.0,8.0,3.0,15.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Tri(6);
            var expected4 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Tri(7);
            var expected5 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Tri(8);
            var expected6 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Tri(9);
            var expected7 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Tri(20);
            var expected8 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0,6.0,48.0,7.0,63.0,8.0,80.0,9.0,99.0,10.0,120.0,11.0};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = Tri(0);
            var expected9 = new List<object> {1};
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = Tri(1);
            var expected10 = new List<object> {1,3};
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

        }
    }
}
```
