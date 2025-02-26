# 107 -- Count even/odd integer palindromes up to n

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
        /// Given a positive integer n, return a tuple that has the number of even and odd
        /// integer palindromes that fall within the range(1, n), inclusive.
        /// 
        /// Example 1:
        /// 
        /// Input: 3
        /// Output: (1, 2)
        /// Explanation:
        /// Integer palindrome are 1, 2, 3. one of them is even, and two of them are odd.
        /// 
        /// Example 2:
        /// 
        /// Input: 12
        /// Output: (4, 6)
        /// Explanation:
        /// Integer palindrome are 1, 2, 3, 4, 5, 6, 7, 8, 9, 11. four of them are even, and 6 of them are odd.
        /// 
        /// Note:
        /// 1. 1 <= n <= 10^3
        /// 2. returned tuple has the number of even and odd integer palindromes respectively.
        /// 
        /// </summary>
        public static List<int> EvenOddPalindrome (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = EvenOddPalindrome(123);
            var expected1 = new List<int> {8,13};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = EvenOddPalindrome(12);
            var expected2 = new List<int> {4,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = EvenOddPalindrome(3);
            var expected3 = new List<int> {1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = EvenOddPalindrome(63);
            var expected4 = new List<int> {6,8};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = EvenOddPalindrome(25);
            var expected5 = new List<int> {5,6};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = EvenOddPalindrome(19);
            var expected6 = new List<int> {4,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = EvenOddPalindrome(9);
            var expected7 = new List<int> {4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = EvenOddPalindrome(1);
            var expected8 = new List<int> {0,1};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
