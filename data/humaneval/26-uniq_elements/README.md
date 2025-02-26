# 26 -- Remove duplicates, keep order intact

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
        /// From a list of integers, remove all elements that occur more than once.
        /// Keep order of elements left the same as in the input.
        /// >>> RemoveDuplicates([1, 2, 3, 2, 4])
        /// [1, 3, 4]
        /// 
        /// </summary>
        public static List<int> RemoveDuplicates (List<int> numbers) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = RemoveDuplicates(new List<int> {});
            var expected1 = new List<int> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = RemoveDuplicates(new List<int> {1,2,3,4});
            var expected2 = new List<int> {1,2,3,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = RemoveDuplicates(new List<int> {1,2,3,2,4,3,5});
            var expected3 = new List<int> {1,4,5};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
