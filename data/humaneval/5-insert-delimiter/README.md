
# 5 -- Inserts delimiter between list elements

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
        /// Insert a number 'delimeter' between every two consecutive elements of input list `numbers'
        /// >>> Intersperse([], 4)
        /// []
        /// >>> Intersperse([1, 2, 3], 4)
        /// [1, 4, 2, 4, 3]
        /// 
        /// </summary>
        public static List<int> Intersperse (List<int> numbers, int delimeter) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Intersperse(new List<int> {},7);
            var expected1 = new List<int> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Intersperse(new List<int> {5,6,3,2},8);
            var expected2 = new List<int> {5,8,6,8,3,8,2};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Intersperse(new List<int> {2,2,2},2);
            var expected3 = new List<int> {2,2,2,2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
