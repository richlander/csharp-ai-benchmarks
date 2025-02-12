
# 71 -- Calculate triangle area or return -1 if invalid

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
        /// Given the lengths of the three sides of a triangle. Return the area of
        /// the triangle rounded to 2 decimal points if the three sides form a valid triangle. 
        /// Otherwise return -1
        /// Three sides make a valid triangle when the sum of any two sides is greater 
        /// than the third side.
        /// Example:
        /// TriangleArea(3, 4, 5) == 6.00
        /// TriangleArea(1, 2, 10) == -1
        /// 
        /// </summary>
        public static object TriangleArea (int a, int b, int c) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = TriangleArea(3,4,5);
            var expected1 = 6.0;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = TriangleArea(1,2,10);
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = TriangleArea(4,8,5);
            var expected3 = 8.18;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = TriangleArea(2,2,2);
            var expected4 = 1.73;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = TriangleArea(1,2,3);
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = TriangleArea(10,5,7);
            var expected6 = 16.25;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = TriangleArea(2,6,3);
            var expected7 = -1;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = TriangleArea(1,1,1);
            var expected8 = 0.43;
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

            var actual9 = TriangleArea(2,2,10);
            var expected9 = -1;
            var result9 = compareLogic.Compare(actual9, expected9);
            if (!result9.AreEqual) {throw new Exception("Exception --- test case 8 failed to pass");}

        }
    }
}
```
