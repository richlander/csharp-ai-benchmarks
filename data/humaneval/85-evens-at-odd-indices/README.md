
# 85 -- Add evens at odd indices from the list

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
        /// Given a non-empty list of integers lst. Add the even elements that are at odd indices..
        /// 
        /// 
        /// Examples:
        /// Add([4, 2, 6, 7]) ==> 2 
        /// 
        /// </summary>
        public static int Add (List<int> lst) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Add(new List<int> {4,88});
            var expected1 = 88;
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Add(new List<int> {4,5,6,7,2,122});
            var expected2 = 122;
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Add(new List<int> {4,0,6,7});
            var expected3 = 0;
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Add(new List<int> {4,4,6,8});
            var expected4 = 12;
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
