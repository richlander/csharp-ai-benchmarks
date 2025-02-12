
# 25 -- Return ordered list of prime factors of a number

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
        /// Return list of prime factors of given integer in the order from smallest to largest.
        /// Each of the factors should be listed number of times corresponding to how many times it appeares in factorization.
        /// Input number should be equal to the product of all factors
        /// >>> Factorize(8)
        /// [2, 2, 2]
        /// >>> Factorize(25)
        /// [5, 5]
        /// >>> Factorize(70)
        /// [2, 5, 7]
        /// 
        /// </summary>
        public static List<int> Factorize (int n) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Factorize(2);
            var expected1 = new List<int> {2};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Factorize(4);
            var expected2 = new List<int> {2,2};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Factorize(8);
            var expected3 = new List<int> {2,2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Factorize(57);
            var expected4 = new List<int> {3,19};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Factorize(3249);
            var expected5 = new List<int> {3,3,19,19};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Factorize(185193);
            var expected6 = new List<int> {3,3,3,19,19,19};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Factorize(20577);
            var expected7 = new List<int> {3,19,19,19};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

            var actual8 = Factorize(18);
            var expected8 = new List<int> {2,3,3};
            var result8 = compareLogic.Compare(actual8, expected8);
            if (!result8.AreEqual) {throw new Exception("Exception --- test case 7 failed to pass");}

        }
    }
}
```
