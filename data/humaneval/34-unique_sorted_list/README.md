# 34 -- Sorted unique elements from a list

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
        /// Return sorted Unique elements in a list
        /// >>> Unique([5, 3, 5, 2, 3, 3, 9, 0, 123])
        /// [0, 2, 3, 5, 9, 123]
        /// 
        /// </summary>
        public static List<int> Unique (List<int> l) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Unique(new List<int> {5,3,5,2,3,3,9,0,123});
            var expected1 = new List<int> {0,2,3,5,9,123};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

        }
    }
}
```
