
# 7 -- Filter list of strings by given substring

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
        /// Filter an input list of strings only for ones that contain given substring
        /// >>> FilterBySubstring([], 'a')
        /// []
        /// >>> FilterBySubstring(['abc', 'bacd', 'cde', 'array'], 'a')
        /// ['abc', 'bacd', 'array']
        /// 
        /// </summary>
        public static List<string> FilterBySubstring (List<string> strings, string substring) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FilterBySubstring(new List<string> {},"john");
            var expected1 = new List<string> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FilterBySubstring(new List<string> {"xxx","asd","xxy","john doe","xxxAAA","xxx"},"xxx");
            var expected2 = new List<string> {"xxx","xxxAAA","xxx"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = FilterBySubstring(new List<string> {"xxx","asd","aaaxxy","john doe","xxxAAA","xxx"},"xx");
            var expected3 = new List<string> {"xxx","aaaxxy","xxxAAA","xxx"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = FilterBySubstring(new List<string> {"grunt","trumpet","prune","gruesome"},"run");
            var expected4 = new List<string> {"grunt","prune"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
