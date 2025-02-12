
# 29 -- Filter strings by starting prefix

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
        /// Filter an input list of strings only for ones that start with a given prefix.
        /// >>> FilterByPrefix([], 'a')
        /// []
        /// >>> FilterByPrefix(['abc', 'bcd', 'cde', 'array'], 'a')
        /// ['abc', 'array']
        /// 
        /// </summary>
        public static List<string> FilterByPrefix (List<string> strings, string prefix) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FilterByPrefix(new List<string> {},"john");
            var expected1 = new List<string> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FilterByPrefix(new List<string> {"xxx","asd","xxy","john doe","xxxAAA","xxx"},"xxx");
            var expected2 = new List<string> {"xxx","xxxAAA","xxx"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

        }
    }
}
```
