# 137 -- Compare integers, floats, strings, return larger

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
        /// Create a function that takes integers, floats, or strings representing
        /// real numbers, and returns the larger variable in its given variable type.
        /// Return None if the values are equal.
        /// Note: If a real number is represented as a string, the floating point might be . or ,
        /// 
        /// CompareOne(1, 2.5) ➞ 2.5
        /// CompareOne(1, "2,3") ➞ "2,3"
        /// CompareOne("5,1", "6") ➞ "6"
        /// CompareOne("1", 1) ➞ None
        /// 
        /// </summary>
        public static object CompareOne (object a, object b) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CompareOne(1,2);
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CompareOne(1,2.5);
            var expected2 = 2.5;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CompareOne(2,3);
            var expected3 = 3;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CompareOne(5,6);
            var expected4 = 6;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CompareOne(1,"2,3");
            var expected5 = "2,3";
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = CompareOne("5,1","6");
            var expected6 = "6";
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = CompareOne("1","2");
            var expected7 = "2";
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = CompareOne("1",1);
            var expected8 = null;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
