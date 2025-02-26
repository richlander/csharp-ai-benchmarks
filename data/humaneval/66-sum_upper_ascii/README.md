# 66 -- Sum ASCII of uppercase in string function

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
        /// Task
        /// Write a function that takes a string as input and returns the sum of the upper characters only'
        /// ASCII codes.
        /// 
        /// Examples:
        /// DigitSum("") => 0
        /// DigitSum("abAB") => 131
        /// DigitSum("abcCd") => 67
        /// DigitSum("helloE") => 69
        /// DigitSum("woArBld") => 131
        /// DigitSum("aAaaaXa") => 153
        /// 
        /// </summary>
        public static int DigitSum (string s) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = DigitSum("");
            var expected1 = 0;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = DigitSum("abAB");
            var expected2 = 131;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = DigitSum("abcCd");
            var expected3 = 67;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = DigitSum("helloE");
            var expected4 = 69;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = DigitSum("woArBld");
            var expected5 = 131;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = DigitSum("aAaaaXa");
            var expected6 = 153;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = DigitSum(" How are yOu?");
            var expected7 = 151;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = DigitSum("You arE Very Smart");
            var expected8 = 327;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
