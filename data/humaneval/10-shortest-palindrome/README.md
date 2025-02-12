
# 10 -- Create shortest palindrome from a given string

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
        /// Find the shortest palindrome that begins with a supplied string.
        /// Algorithm idea is simple:
        /// - Find the longest postfix of supplied string that is a palindrome.
        /// - Append to the end of the string reverse of a string prefix that comes before the palindromic suffix.
        /// >>> MakePalindrome('')
        /// ''
        /// >>> MakePalindrome('cat')
        /// 'catac'
        /// >>> MakePalindrome('cata')
        /// 'catac'
        /// 
        /// </summary>
        public static string MakePalindrome (string string0) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = MakePalindrome("");
            var expected1 = "";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = MakePalindrome("x");
            var expected2 = "x";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = MakePalindrome("xyz");
            var expected3 = "xyzyx";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = MakePalindrome("xyx");
            var expected4 = "xyx";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = MakePalindrome("jerry");
            var expected5 = "jerryrrej";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
