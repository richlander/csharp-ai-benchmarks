
# 9 -- Generate rolling max from integer list

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
        /// From a given list of integers, generate a list of rolling maximum element found until given moment
        /// in the sequence.
        /// >>> RollingMax([1, 2, 3, 2, 3, 4, 2])
        /// [1, 2, 3, 3, 3, 4, 4]
        /// 
        /// </summary>
        public static List<int> RollingMax (List<int> numbers) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = RollingMax(new List<int> {});
            var expected1 = new List<int> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = RollingMax(new List<int> {1,2,3,4});
            var expected2 = new List<int> {1,2,3,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = RollingMax(new List<int> {4,3,2,1});
            var expected3 = new List<int> {4,4,4,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = RollingMax(new List<int> {3,2,3,100,3});
            var expected4 = new List<int> {3,3,3,100,100};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
