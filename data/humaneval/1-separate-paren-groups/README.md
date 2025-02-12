
# 1 -- Separate balanced parenthesis groups

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
        /// Input to this function is a string containing multiple groups of nested parentheses. Your goal is to
        /// separate those group into separate strings and return the list of those.
        /// Separate groups are balanced (each open brace is properly closed) and not nested within each other
        /// Ignore any spaces in the input string.
        /// >>> SeparateParenGroups('( ) (( )) (( )( ))')
        /// ['()', '(())', '(()())']
        /// 
        /// </summary>
        public static List<string> SeparateParenGroups (string paren_string) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SeparateParenGroups("(()()) ((())) () ((())()())");
            var expected1 = new List<string> {"(()())","((()))","()","((())()())"};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SeparateParenGroups("() (()) ((())) (((())))");
            var expected2 = new List<string> {"()","(())","((()))","(((())))"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SeparateParenGroups("(()(())((())))");
            var expected3 = new List<string> {"(()(())((())))"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SeparateParenGroups("( ) (( )) (( )( ))");
            var expected4 = new List<string> {"()","(())","(()())"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
