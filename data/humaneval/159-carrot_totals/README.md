# 159 -- Calculate carrots eaten and remaining

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
        /// You're a hungry rabbit, and you already have Eaten a certain number of carrots,
        /// but now you need to Eat more carrots to complete the day's meals.
        /// you should return an array of [ total number of Eaten carrots after your meals,
        /// the number of carrots left after your meals ]
        /// if there are not enough remaining carrots, you will Eat all remaining carrots, but will still be hungry.
        /// 
        /// Example:
        /// * Eat(5, 6, 10) -> [11, 4]
        /// * Eat(4, 8, 9) -> [12, 1]
        /// * Eat(1, 10, 10) -> [11, 0]
        /// * Eat(2, 11, 5) -> [7, 0]
        /// 
        /// Variables:
        /// @number : integer
        /// the number of carrots that you have Eaten.
        /// @need : integer
        /// the number of carrots that you need to Eat.
        /// @remaining : integer
        /// the number of remaining carrots thet exist in stock
        /// 
        /// Constrain:
        /// * 0 <= number <= 1000
        /// * 0 <= need <= 1000
        /// * 0 <= remaining <= 1000
        /// 
        /// Have fun :)
        /// 
        /// </summary>
        public static List<int> Eat (int number, int need, int remaining) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Eat(5,6,10);
            var expected1 = new List<int> {11,4};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Eat(4,8,9);
            var expected2 = new List<int> {12,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Eat(1,10,10);
            var expected3 = new List<int> {11,0};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Eat(2,11,5);
            var expected4 = new List<int> {7,0};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Eat(4,5,7);
            var expected5 = new List<int> {9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Eat(4,5,1);
            var expected6 = new List<int> {5,0};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

        }
    }
}
```
