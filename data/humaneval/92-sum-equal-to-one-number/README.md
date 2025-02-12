
# 92 -- Check if one number equals the sum of others

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
        /// Create a function that takes 3 numbers.
        /// Returns true if one of the numbers is equal to the sum of the other two, and all numbers are integers.
        /// Returns false in any other cases.
        /// 
        /// Examples
        /// AnyInt(5, 2, 7) ➞ True
        /// 
        /// AnyInt(3, 2, 2) ➞ False
        /// 
        /// AnyInt(3, -2, 1) ➞ True
        /// 
        /// AnyInt(3.6, -2.2, 2) ➞ False
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        public static bool AnyInt (object x, object y, object z) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = AnyInt(2,3,1);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = AnyInt(2.5,2,3);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = AnyInt(1.5,5,3.5);
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = AnyInt(2,6,2);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = AnyInt(4,2,2);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = AnyInt(2.2,2.2,2.2);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = AnyInt(-4,6,2);
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = AnyInt(2,1,1);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = AnyInt(3,4,7);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = AnyInt(3.0,4,7);
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

        }
    }
}
```
