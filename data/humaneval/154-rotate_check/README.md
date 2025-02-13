# 154 -- Check if any rotation of word is in text

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
        /// You are given 2 words. You need to return True if the second word or any of its rotations is a substring in the first word
        /// CycpatternCheck("abcd","abd") => False
        /// CycpatternCheck("hello","ell") => True
        /// CycpatternCheck("whassup","psus") => False
        /// CycpatternCheck("abab","baa") => True
        /// CycpatternCheck("efef","eeff") => False
        /// CycpatternCheck("himenss","simen") => True
        /// 
        /// 
        /// </summary>
        public static bool CycpatternCheck (string a, string b) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CycpatternCheck("xyzw","xyw");
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CycpatternCheck("yello","ell");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CycpatternCheck("whattup","ptut");
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CycpatternCheck("efef","fee");
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CycpatternCheck("abab","aabb");
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = CycpatternCheck("winemtt","tinem");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
