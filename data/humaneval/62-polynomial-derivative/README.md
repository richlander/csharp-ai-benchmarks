
# 62 -- Polynomial derivative calculator

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
        /// xs represent coefficients of a polynomial.
        /// xs[0] + xs[1] * x + xs[2] * x^2 + ....
        /// Return Derivative of this polynomial in the same form.
        /// >>> Derivative([3, 1, 2, 4, 5])
        /// [1, 4, 12, 20]
        /// >>> Derivative([1, 2, 3])
        /// [2, 6]
        /// 
        /// </summary>
        public static List<int> Derivative (List<int> xs) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Derivative(new List<int> {3,1,2,4,5});
            var expected1 = new List<int> {1,4,12,20};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Derivative(new List<int> {1,2,3});
            var expected2 = new List<int> {2,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Derivative(new List<int> {3,2,1});
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Derivative(new List<int> {3,2,1,0,4});
            var expected4 = new List<int> {2,2,0,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Derivative(new List<int> {1});
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
