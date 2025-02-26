# 41 -- Cars collide but continue unaffected

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
        /// Imagine a road that's a perfectly straight infinitely long line.
        /// n cars are driving left to right;  simultaneously, a different set of n cars
        /// are driving right to left.   The two sets of cars start out being very far from
        /// each other.  All cars move in the same speed.  Two cars are said to collide
        /// when a car that's moving left to right hits a car that's moving right to left.
        /// However, the cars are infinitely sturdy and strong; as a result, they continue moving
        /// in their trajectory as if they did not collide.
        /// 
        /// This function outputs the number of such collisions.
        /// 
        /// </summary>
        public static int CarRaceCollision (int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = CarRaceCollision(2);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = CarRaceCollision(3);
            var expected2 = 9;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = CarRaceCollision(4);
            var expected3 = 16;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = CarRaceCollision(8);
            var expected4 = 64;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = CarRaceCollision(10);
            var expected5 = 100;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
