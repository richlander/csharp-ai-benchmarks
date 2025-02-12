
# 152 -- Check guess accuracy; return differences array

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
        /// I think we all remember that feeling when the result of some long-awaited
        /// event is finally known. The feelings and thoughts you have at that moment are
        /// definitely worth noting down and comparing.
        /// Your task is to determine if a person correctly guessed the results of a number of matches.
        /// You are given two arrays of scores and guesses of equal length, where each index shows a match. 
        /// Return an array of the same length denoting how far off each guess was. If they have guessed correctly,
        /// the value is 0, and if not, the value is the absolute difference between the guess and the score.
        /// 
        /// 
        /// example:
        /// 
        /// Compare([1,2,3,4,5,1],[1,2,3,4,2,-2]) -> [0,0,0,0,3,3]
        /// Compare([0,5,0,0,0,4],[4,1,1,0,0,-2]) -> [4,4,1,0,0,6]
        /// 
        /// </summary>
        public static List<int> Compare (List<int> game, List<int> guess) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Compare(new List<int> {1,2,3,4,5,1},new List<int> {1,2,3,4,2,-2});
            var expected1 = new List<int> {0,0,0,0,3,3};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Compare(new List<int> {0,0,0,0,0,0},new List<int> {0,0,0,0,0,0});
            var expected2 = new List<int> {0,0,0,0,0,0};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Compare(new List<int> {1,2,3},new List<int> {-1,-2,-3});
            var expected3 = new List<int> {2,4,6};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Compare(new List<int> {1,2,3,5},new List<int> {-1,2,3,4});
            var expected4 = new List<int> {2,0,0,1};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

        }
    }
}
```
