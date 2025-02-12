
# 144 -- Check if product of fractions is whole number

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
        /// Your task is to implement a function that will Simplify the expression
        /// x * n. The function returns True if x * n evaluates to a whole number and False
        /// otherwise. Both x and n, are string representation of a fraction, and have the following format,
        /// <numerator>/<denominator> where both numerator and denominator are positive whole numbers.
        /// 
        /// You can assume that x, and n are valid fractions, and do not have zero as denominator.
        /// 
        /// Simplify("1/5", "5/1") = True
        /// Simplify("1/6", "2/1") = False
        /// Simplify("7/10", "10/2") = False
        /// 
        /// </summary>
        public static bool Simplify (string x, string n) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Simplify("1/5","5/1");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Simplify("1/6","2/1");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Simplify("5/1","3/1");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Simplify("7/10","10/2");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Simplify("2/10","50/10");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Simplify("7/2","4/2");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Simplify("11/6","6/1");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Simplify("2/3","5/2");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = Simplify("5/2","3/5");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

            var actual10 = Simplify("2/4","8/4");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            if (!result10.AreEqual) {throw new Exception("Exception --- test case 9 failed to pass");}

            var actual11 = Simplify("2/4","4/2");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            if (!result11.AreEqual) {throw new Exception("Exception --- test case 10 failed to pass");}

            var actual12 = Simplify("1/5","5/1");
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            if (!result12.AreEqual) {throw new Exception("Exception --- test case 11 failed to pass");}

            var actual13 = Simplify("1/5","1/5");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            if (!result13.AreEqual) {throw new Exception("Exception --- test case 12 failed to pass");}

        }
    }
}
```
