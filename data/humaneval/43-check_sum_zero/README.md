# 43 -- Check if list has two numbers summing to zero

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
        /// PairsSumToZero takes a list of integers as an input.
        /// it returns True if there are two distinct elements in the list that
        /// sum to zero, and False otherwise.
        /// >>> PairsSumToZero([1, 3, 5, 0])
        /// False
        /// >>> PairsSumToZero([1, 3, -2, 1])
        /// False
        /// >>> PairsSumToZero([1, 2, 3, 7])
        /// False
        /// >>> PairsSumToZero([2, 4, -5, 3, 5, 7])
        /// True
        /// >>> PairsSumToZero([1])
        /// False
        /// 
        /// </summary>
        public static bool PairsSumToZero (List<int> l) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = PairsSumToZero(new List<int> {1,3,5,0});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = PairsSumToZero(new List<int> {1,3,-2,1});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = PairsSumToZero(new List<int> {1,2,3,7});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = PairsSumToZero(new List<int> {2,4,-5,3,5,7});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = PairsSumToZero(new List<int> {1});
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = PairsSumToZero(new List<int> {-3,9,-1,3,2,30});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = PairsSumToZero(new List<int> {-3,9,-1,3,2,31});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = PairsSumToZero(new List<int> {-3,9,-1,4,2,30});
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = PairsSumToZero(new List<int> {-3,9,-1,4,2,31});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

        }
    }
}
```
