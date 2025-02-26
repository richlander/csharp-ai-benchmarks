# 156 -- Convert integer to lowercase Roman numeral

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
        /// Given a positive integer, obtain its roman numeral equivalent as a string,
        /// and return it in lowercase.
        /// Restrictions: 1 <= num <= 1000
        /// 
        /// Examples:
        /// >>> IntToMiniRoman(19) == 'xix'
        /// >>> IntToMiniRoman(152) == 'clii'
        /// >>> IntToMiniRoman(426) == 'cdxxvi'
        /// 
        /// </summary>
        public static string IntToMiniRoman (int number) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = IntToMiniRoman(19);
            var expected1 = "xix";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = IntToMiniRoman(152);
            var expected2 = "clii";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = IntToMiniRoman(251);
            var expected3 = "ccli";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = IntToMiniRoman(426);
            var expected4 = "cdxxvi";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = IntToMiniRoman(500);
            var expected5 = "d";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = IntToMiniRoman(1);
            var expected6 = "i";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = IntToMiniRoman(4);
            var expected7 = "iv";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = IntToMiniRoman(43);
            var expected8 = "xliii";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = IntToMiniRoman(90);
            var expected9 = "xc";
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = IntToMiniRoman(94);
            var expected10 = "xciv";
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = IntToMiniRoman(532);
            var expected11 = "dxxxii";
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = IntToMiniRoman(900);
            var expected12 = "cm";
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

            var actual13 = IntToMiniRoman(994);
            var expected13 = "cmxciv";
            var result13 = compareLogic.Compare(actual13, expected13);
            if (!result13.AreEqual) {throw new Exception("Exception --- test case 12 failed to pass");}

            var actual14 = IntToMiniRoman(1000);
            var expected14 = "m";
            var result14 = compareLogic.Compare(actual14, expected14);
            if (!result14.AreEqual) {throw new Exception("Exception --- test case 13 failed to pass");}

        }
    }
}
```
