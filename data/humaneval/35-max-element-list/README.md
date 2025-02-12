
# 35 -- Find the max element in a list

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
        /// Return maximum element in the list.
        /// >>> MaxElement([1, 2, 3])
        /// 3
        /// >>> MaxElement([5, 3, -5, 2, -3, 3, 9, 0, 123, 1, -10])
        /// 123
        /// 
        /// </summary>
        public static int MaxElement (List<int> l) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MaxElement(new List<int> {1,2,3});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MaxElement(new List<int> {5,3,-5,2,-3,3,9,0,124,1,-10});
            var expected2 = 124;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

        }
    }
}
```
