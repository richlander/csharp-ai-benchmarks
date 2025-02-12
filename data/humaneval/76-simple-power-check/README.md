
# 76 -- Check if a number is a simple power of another

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
        /// Your task is to write a function that returns true if a number x is a simple
        /// power of n and false in other cases.
        /// x is a simple power of n if n**int=x
        /// For example:
        /// IsSimplePower(1, 4) => true
        /// IsSimplePower(2, 2) => true
        /// IsSimplePower(8, 2) => true
        /// IsSimplePower(3, 2) => false
        /// IsSimplePower(3, 1) => false
        /// IsSimplePower(5, 3) => false
        /// 
        /// </summary>
        public static bool IsSimplePower (int x, int n) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = IsSimplePower(16,2);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = IsSimplePower(143214,16);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = IsSimplePower(4,2);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = IsSimplePower(9,3);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = IsSimplePower(16,4);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = IsSimplePower(24,2);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = IsSimplePower(128,4);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = IsSimplePower(12,6);
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = IsSimplePower(1,1);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = IsSimplePower(1,12);
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

        }
    }
}
```
