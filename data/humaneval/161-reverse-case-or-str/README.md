
# 161 -- Reverse case or reverse string

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
        /// You are given a string s.
        /// if s[i] is a letter, reverse its case from lower to upper or vise versa, 
        /// otherwise keep it as it is.
        /// If the string contains no letters, reverse the string.
        /// The function should return the resulted string.
        /// Examples
        /// Solve("1234") = "4321"
        /// Solve("ab") = "AB"
        /// Solve("#a@C") = "#A@c"
        /// 
        /// </summary>
        public static string Solve (string s) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Solve("AsDf");
            var expected1 = "aSdF";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Solve("1234");
            var expected2 = "4321";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Solve("ab");
            var expected3 = "AB";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Solve("#a@C");
            var expected4 = "#A@c";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Solve("#AsdfW^45");
            var expected5 = "#aSDFw^45";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Solve("#6@2");
            var expected6 = "2@6#";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Solve("#$a^D");
            var expected7 = "#$A^d";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Solve("#ccc");
            var expected8 = "#CCC";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
