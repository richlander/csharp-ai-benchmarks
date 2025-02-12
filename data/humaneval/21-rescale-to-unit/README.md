
# 21 -- Rescale numbers to have min as 0 and max as 1

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
        /// Given list of numbers (of at least two elements), apply a linear transform to that list,
        /// such that the smallest number will become 0 and the largest will become 1
        /// >>> RescaleToUnit([1.0, 2.0, 3.0, 4.0, 5.0])
        /// [0.0, 0.25, 0.5, 0.75, 1.0]
        /// 
        /// </summary>
        public static List<double> RescaleToUnit (List<double> numbers) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = RescaleToUnit(new List<double> {2.0,49.9});
            var expected1 = new List<double> {0.0,1.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = RescaleToUnit(new List<double> {100.0,49.9});
            var expected2 = new List<double> {1.0,0.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = RescaleToUnit(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = new List<double> {0.0,0.25,0.5,0.75,1.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = RescaleToUnit(new List<double> {2.0,1.0,5.0,3.0,4.0});
            var expected4 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = RescaleToUnit(new List<double> {12.0,11.0,15.0,13.0,14.0});
            var expected5 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
