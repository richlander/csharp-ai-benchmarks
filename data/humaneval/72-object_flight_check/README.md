# 72 -- Function checks if list is balanced and light

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
        /// Write a function that returns True if the object q will fly, and False otherwise.
        /// The object q will fly if it's balanced (it is a palindromic list) and the sum of its elements is less than or equal the maximum possible weight w.
        /// 
        /// Example:
        /// WillItFly([1, 2], 5) ➞ False 
        /// # 1+2 is less than the maximum possible weight, but it's unbalanced.
        /// 
        /// WillItFly([3, 2, 3], 1) ➞ False
        /// # it's balanced, but 3+2+3 is more than the maximum possible weight.
        /// 
        /// WillItFly([3, 2, 3], 9) ➞ True
        /// # 3+2+3 is less than the maximum possible weight, and it's balanced.
        /// 
        /// WillItFly([3], 5) ➞ True
        /// # 3 is less than the maximum possible weight, and it's balanced.
        /// 
        /// </summary>
        public static bool WillItFly (List<int> q, int w) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = WillItFly(new List<int> {3,2,3},9);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = WillItFly(new List<int> {1,2},5);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = WillItFly(new List<int> {3},5);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = WillItFly(new List<int> {3,2,3},1);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = WillItFly(new List<int> {1,2,3},6);
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = WillItFly(new List<int> {5},5);
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
