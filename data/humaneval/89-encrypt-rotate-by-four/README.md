
# 89 -- Function to encrypt by rotating alphabet by four

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
        /// Create a function Encrypt that takes a string as an argument and
        /// returns a string Encrypted with the alphabet being rotated. 
        /// The alphabet should be rotated in a manner such that the letters 
        /// shift down by two multiplied to two places.
        /// For example:
        /// Encrypt('hi') returns 'lm'
        /// Encrypt('asdfghjkl') returns 'ewhjklnop'
        /// Encrypt('gf') returns 'kj'
        /// Encrypt('et') returns 'ix'
        /// 
        /// </summary>
        public static string Encrypt (string s) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Encrypt("hi");
            var expected1 = "lm";
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Encrypt("asdfghjkl");
            var expected2 = "ewhjklnop";
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Encrypt("gf");
            var expected3 = "kj";
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Encrypt("et");
            var expected4 = "ix";
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Encrypt("faewfawefaewg");
            var expected5 = "jeiajeaijeiak";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Encrypt("hellomyfriend");
            var expected6 = "lippsqcjvmirh";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Encrypt("dxzdlmnilfuhmilufhlihufnmlimnufhlimnufhfucufh");
            var expected7 = "hbdhpqrmpjylqmpyjlpmlyjrqpmqryjlpmqryjljygyjl";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Encrypt("a");
            var expected8 = "e";
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
