
# 54 -- Check if words have same characters

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
        /// Check if two words have the same characters.
        /// >>> SameChars('eabcdzzzz', 'dddzzzzzzzddeddabc')
        /// True
        /// >>> SameChars('abcd', 'dddddddabc')
        /// True
        /// >>> SameChars('dddddddabc', 'abcd')
        /// True
        /// >>> SameChars('eabcd', 'dddddddabc')
        /// False
        /// >>> SameChars('abcd', 'dddddddabce')
        /// False
        /// >>> SameChars('eabcdzzzz', 'dddzzzzzzzddddabc')
        /// False
        /// 
        /// </summary>
        public static bool SameChars (string s0, string s1) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = SameChars("eabcdzzzz","dddzzzzzzzddeddabc");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = SameChars("abcd","dddddddabc");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = SameChars("dddddddabc","abcd");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = SameChars("eabcd","dddddddabc");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = SameChars("abcd","dddddddabcf");
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = SameChars("eabcdzzzz","dddzzzzzzzddddabc");
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = SameChars("aabb","aaccc");
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
