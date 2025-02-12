
# 160 -- Build and evaluate an algebraic expression

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
        /// Given two lists operator, and operand. The first list has basic algebra operations, and 
        /// the second list is a list of integers. Use the two given lists to build the algebric 
        /// expression and return the evaluation of this expression.
        /// 
        /// The basic algebra operations:
        /// Addition ( + ) 
        /// Subtraction ( - ) 
        /// Multiplication ( * ) 
        /// Floor division ( // ) 
        /// Exponentiation ( ** ) 
        /// 
        /// Example:
        /// operator['+', '*', '-']
        /// array = [2, 3, 4, 5]
        /// result = 2 + 3 * 4 - 5
        /// => result = 9
        /// 
        /// Note:
        /// The length of operator list is equal to the length of operand list minus one.
        /// Operand is a list of of non-negative integers.
        /// Operator list has at least one operator, and operand list has at least two operands.
        /// 
        /// 
        /// </summary>
        public static int DoAlgebra (List<string> operator, List<int> operand) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = DoAlgebra(new List<string> {"**","*","+"},new List<int> {2,3,4,5});
            var expected1 = 37;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = DoAlgebra(new List<string> {"+","*","-"},new List<int> {2,3,4,5});
            var expected2 = 9;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = DoAlgebra(new List<string> {"//","*"},new List<int> {7,3,4});
            var expected3 = 8;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
