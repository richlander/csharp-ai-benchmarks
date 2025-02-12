
# 123 -- Return sorted list of odd numbers in Collatz sequence

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
        /// Given a positive integer n, return a sorted list that has the odd numbers in collatz sequence.
        /// 
        /// The Collatz conjecture is a conjecture in mathematics that concerns a sequence defined
        /// as follows: start with any positive integer n. Then each term is obtained from the 
        /// previous term as follows: if the previous term is even, the next term is one half of 
        /// the previous term. If the previous term is odd, the next term is 3 times the previous
        /// term plus 1. The conjecture is that no matter what value of n, the sequence will always reach 1.
        /// 
        /// Note: 
        /// 1. Collatz(1) is [1].
        /// 2. returned list sorted in increasing order.
        /// 
        /// For example:
        /// GetOddCollatz(5) returns [1, 5] # The collatz sequence for 5 is [5, 16, 8, 4, 2, 1], so the odd numbers are only 1, and 5.
        /// 
        /// </summary>
        public static List<int> GetOddCollatz (int n) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = GetOddCollatz(14);
            var expected1 = new List<int> {1,5,7,11,13,17};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = GetOddCollatz(5);
            var expected2 = new List<int> {1,5};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = GetOddCollatz(12);
            var expected3 = new List<int> {1,3,5};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = GetOddCollatz(1);
            var expected4 = new List<int> {1};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
