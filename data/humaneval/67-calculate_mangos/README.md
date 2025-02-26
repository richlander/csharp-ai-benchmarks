# 67 -- Calculate mango fruits in basket

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
        /// In this task, you will be given a string that represents a number of apples and oranges 
        /// that are distributed in a basket of fruit this basket contains 
        /// apples, oranges, and mango fruits. Given the string that represents the total number of 
        /// the oranges and apples and an integer that represent the total number of the fruits 
        /// in the basket return the number of the mango fruits in the basket.
        /// for examble:
        /// FruitDistribution("5 apples and 6 oranges", 19) ->19 - 5 - 6 = 8
        /// FruitDistribution("0 apples and 1 oranges",3) -> 3 - 0 - 1 = 2
        /// FruitDistribution("2 apples and 3 oranges", 100) -> 100 - 2 - 3 = 95
        /// FruitDistribution("100 apples and 1 oranges",120) -> 120 - 100 - 1 = 19
        /// 
        /// </summary>
        public static int FruitDistribution (string s, int n) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FruitDistribution("5 apples and 6 oranges",19);
            var expected1 = 8;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FruitDistribution("5 apples and 6 oranges",21);
            var expected2 = 10;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = FruitDistribution("0 apples and 1 oranges",3);
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = FruitDistribution("1 apples and 0 oranges",3);
            var expected4 = 2;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = FruitDistribution("2 apples and 3 oranges",100);
            var expected5 = 95;
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = FruitDistribution("2 apples and 3 oranges",5);
            var expected6 = 0;
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = FruitDistribution("1 apples and 100 oranges",120);
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
