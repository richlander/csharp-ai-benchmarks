
# 105 -- Sort, reverse, map 1-9 to names in the array

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
        /// Given an array of integers, sort the integers that are between 1 and 9 inclusive,
        /// reverse the resulting array, and then replace each digit by its corresponding name from
        /// "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine".
        /// 
        /// For example:
        /// arr = [2, 1, 1, 4, 5, 8, 2, 3]   
        /// -> sort arr -> [1, 1, 2, 2, 3, 4, 5, 8] 
        /// -> reverse arr -> [8, 5, 4, 3, 2, 2, 1, 1]
        /// return ["Eight", "Five", "Four", "Three", "Two", "Two", "One", "One"]
        /// 
        /// If the array is empty, return an empty array:
        /// arr = []
        /// return []
        /// 
        /// If the array has any strange number ignore it:
        /// arr = [1, -1 , 55] 
        /// -> sort arr -> [-1, 1, 55]
        /// -> reverse arr -> [55, 1, -1]
        /// return = ['One']
        /// 
        /// </summary>
        public static List<string> ByLength (List<int> arr) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = ByLength(new List<int> {2,1,1,4,5,8,2,3});
            var expected1 = new List<string> {"Eight","Five","Four","Three","Two","Two","One","One"};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = ByLength(new List<int> {});
            var expected2 = new List<string> {};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = ByLength(new List<int> {1,-1,55});
            var expected3 = new List<string> {"One"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = ByLength(new List<int> {1,-1,3,2});
            var expected4 = new List<string> {"Three","Two","One"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = ByLength(new List<int> {9,4,8});
            var expected5 = new List<string> {"Nine","Eight","Four"};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

        }
    }
}
```
