
# 119 -- Check if two strings can form a balanced parentheses

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
        /// You are given a list of two strings, both strings consist of open
        /// parentheses '(' or close parentheses ')' only.
        /// Your job is to check if it is possible to concatenate the two strings in
        /// some order, that the resulting string will be good.
        /// A string S is considered to be good if and only if all parentheses in S
        /// are balanced. For example: the string '(())()' is good, while the string
        /// '())' is not.
        /// Return 'Yes' if there's a way to make a good string, and return 'No' otherwise.
        /// 
        /// Examples:
        /// MatchParens(['()(', ')']) == 'Yes'
        /// MatchParens([')', ')']) == 'No'
        /// 
        /// </summary>
        public static string MatchParens (List<string> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MatchParens(new List<string> {"()(",")"});
            var expected1 = "Yes";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MatchParens(new List<string> {")",")"});
            var expected2 = "No";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = MatchParens(new List<string> {"(()(())","())())"});
            var expected3 = "No";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = MatchParens(new List<string> {")())","(()()("});
            var expected4 = "Yes";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = MatchParens(new List<string> {"(())))","(()())(("});
            var expected5 = "Yes";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = MatchParens(new List<string> {"()","())"});
            var expected6 = "No";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = MatchParens(new List<string> {"(()(","()))()"});
            var expected7 = "Yes";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = MatchParens(new List<string> {"((((","((())"});
            var expected8 = "No";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = MatchParens(new List<string> {")(()","(()("});
            var expected9 = "No";
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = MatchParens(new List<string> {")(",")("});
            var expected10 = "No";
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = MatchParens(new List<string> {"(",")"});
            var expected11 = "Yes";
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = MatchParens(new List<string> {")","("});
            var expected12 = "Yes";
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

        }
    }
}
```
