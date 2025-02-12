
# 64 -- Count vowels including 'y' at word end

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
        /// Write a function VowelsCount which takes a string representing
        /// a word as input and returns the number of vowels in the string.
        /// Vowels in this case are 'a', 'e', 'i', 'o', 'u'. Here, 'y' is also a
        /// vowel, but only when it is at the end of the given word.
        /// 
        /// Example:
        /// >>> VowelsCount("abcde")
        /// 2
        /// >>> VowelsCount("ACEDY")
        /// 3
        /// 
        /// </summary>
        public static int VowelsCount (string s) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = VowelsCount("abcde");
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = VowelsCount("Alone");
            var expected2 = 3;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = VowelsCount("key");
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = VowelsCount("bye");
            var expected4 = 1;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = VowelsCount("keY");
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = VowelsCount("bYe");
            var expected6 = 1;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = VowelsCount("ACEDY");
            var expected7 = 3;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
