# 51 -- Function removes vowels from a string

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
        /// RemoveVowels is a function that takes string and returns string without vowels.
        /// >>> RemoveVowels('')
        /// ''
        /// >>> RemoveVowels("abcdef\nghijklm")
        /// 'bcdf\nghjklm'
        /// >>> RemoveVowels('abcdef')
        /// 'bcdf'
        /// >>> RemoveVowels('aaaaa')
        /// ''
        /// >>> RemoveVowels('aaBAA')
        /// 'B'
        /// >>> RemoveVowels('zbcd')
        /// 'zbcd'
        /// 
        /// </summary>
        public static string RemoveVowels (string text) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = RemoveVowels("");
            var expected1 = "";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = RemoveVowels("abcdef\nghijklm");
            var expected2 = "bcdf\nghjklm";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = RemoveVowels("fedcba");
            var expected3 = "fdcb";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = RemoveVowels("eeeee");
            var expected4 = "";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = RemoveVowels("acBAA");
            var expected5 = "cB";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = RemoveVowels("EcBOO");
            var expected6 = "cB";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = RemoveVowels("ybcd");
            var expected7 = "ybcd";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
