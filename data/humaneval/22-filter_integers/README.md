# 22 -- Extract integers from a list

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
        /// Filter given list of any python values only for integers
        /// >>> FilterIntegers(['a', 3.14, 5])
        /// [5]
        /// >>> FilterIntegers([1, 2, 3, 'abc', {}, []])
        /// [1, 2, 3]
        /// 
        /// </summary>
        public static List<int> FilterIntegers (List<object> values) 
        {
```

## Test

```csharp
        public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = FilterIntegers(new List<object> {});
            var expected1 = new List<int> {};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = FilterIntegers(new List<object> {4,new object {},new List<object> {},23.2,9,"adasd"});
            var expected2 = new List<int> {4,9};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = FilterIntegers(new List<object> {3,"c",3,3,"a","b"});
            var expected3 = new List<int> {3,3,3};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

        }
    }
}
```
