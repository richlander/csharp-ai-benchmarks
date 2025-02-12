
# 128 -- Sum magnitudes, multiply by sign product

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
        /// You are given an array arr of integers and you need to return
        /// sum of magnitudes of integers multiplied by product of all signs
        /// of each number in the array, represented by 1, -1 or 0.
        /// Note: return None for empty arr.
        /// 
        /// Example:
        /// >>> ProdSigns([1, 2, 2, -4]) == -9
        /// >>> ProdSigns([0, 1]) == 0
        /// >>> ProdSigns([]) == None
        /// 
        /// </summary>
        public static object ProdSigns (List<int> arr) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = ProdSigns(new List<int> {1,2,2,-4});
            var expected1 = -9;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = ProdSigns(new List<int> {0,1});
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = ProdSigns(new List<int> {1,1,1,2,3,-1,1});
            var expected3 = -10;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = ProdSigns(new List<int> {});
            var expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = ProdSigns(new List<int> {2,4,1,2,-1,-1,9});
            var expected5 = 20;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = ProdSigns(new List<int> {-1,1,-1,1});
            var expected6 = 4;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = ProdSigns(new List<int> {-1,1,1,1});
            var expected7 = -4;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = ProdSigns(new List<int> {-1,1,1,0});
            var expected8 = 0;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
