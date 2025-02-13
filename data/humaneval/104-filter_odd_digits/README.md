# 104 -- Return sorted list without even digits

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
        /// Given a list of positive integers x. return a sorted list of all 
        /// elements that hasn't any even digit.
        /// 
        /// Note: Returned list should be sorted in increasing order.
        /// 
        /// For example:
        /// >>> UniqueDigits([15, 33, 1422, 1])
        /// [1, 15, 33]
        /// >>> UniqueDigits([152, 323, 1422, 10])
        /// []
        /// 
        /// </summary>
        public static List<int> UniqueDigits (List<int> x) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = UniqueDigits(new List<int> {15,33,1422,1});
            var expected1 = new List<int> {1,15,33};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = UniqueDigits(new List<int> {152,323,1422,10});
            var expected2 = new List<int> {};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = UniqueDigits(new List<int> {12345,2033,111,151});
            var expected3 = new List<int> {111,151};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = UniqueDigits(new List<int> {135,103,31});
            var expected4 = new List<int> {31,135};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
