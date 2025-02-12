
# 8 -- Tuples of sum and product for a list of integers

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
        /// For a given list of integers, return a tuple consisting of a sum and a product of all the integers in a list.
        /// Empty sum should be equal to 0 and empty product should be equal to 1.
        /// >>> SumProduct([])
        /// (0, 1)
        /// >>> SumProduct([1, 2, 3, 4])
        /// (10, 24)
        /// 
        /// </summary>
        public static List<int> SumProduct (List<int> numbers) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SumProduct(new List<int> {});
            var expected1 = new List<int> {0,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SumProduct(new List<int> {1,1,1});
            var expected2 = new List<int> {3,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SumProduct(new List<int> {100,0});
            var expected3 = new List<int> {100,0};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SumProduct(new List<int> {3,5,7});
            var expected4 = new List<int> {15,105};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SumProduct(new List<int> {10});
            var expected5 = new List<int> {10,10};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
