
# 6 -- Find deepest nesting level for each parentheses group

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
        /// Input to this function is a string represented multiple groups for nested parentheses separated by spaces.
        /// For each of the group, output the deepest level of nesting of parentheses.
        /// E.g. (()()) has maximum two levels of nesting while ((())) has three.
        /// 
        /// >>> ParseNestedParens('(()()) ((())) () ((())()())')
        /// [2, 3, 1, 3]
        /// 
        /// </summary>
        public static List<int> ParseNestedParens (string paren_string) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = ParseNestedParens("(()()) ((())) () ((())()())");
            var expected1 = new List<int> {2,3,1,3};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = ParseNestedParens("() (()) ((())) (((())))");
            var expected2 = new List<int> {1,2,3,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = ParseNestedParens("(()(())((())))");
            var expected3 = new List<int> {4};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
