
# 148 -- Solar system planets order and placement

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
        /// There are eight planets in our solar system: the closerst to the Sun 
        /// is Mercury, the next one is Venus, then Earth, Mars, Jupiter, Saturn, 
        /// Uranus, Neptune.
        /// Write a function that takes two planet names as strings planet1 and planet2. 
        /// The function should return a tuple containing all planets whose orbits are 
        /// located between the orbit of planet1 and the orbit of planet2, sorted by 
        /// the proximity to the sun. 
        /// The function should return an empty tuple if planet1 or planet2
        /// are not correct planet names. 
        /// Examples
        /// Bf("Jupiter", "Neptune") ==> ("Saturn", "Uranus")
        /// Bf("Earth", "Mercury") ==> ("Venus")
        /// Bf("Mercury", "Uranus") ==> ("Venus", "Earth", "Mars", "Jupiter", "Saturn")
        /// 
        /// </summary>
        public static List<string> Bf (string planet1, string planet2) 
        {
```

## Test

```csharp
public static void Main(string[] args)
        {
            CompareLogic compareLogic = new CompareLogic();
            var actual1 = Bf("Jupiter","Neptune");
            var expected1 = new List<string> {"Saturn","Uranus"};
            var result1 = compareLogic.Compare(actual1, expected1);
            if (!result1.AreEqual) {throw new Exception("Exception --- test case 0 failed to pass");}

            var actual2 = Bf("Earth","Mercury");
            var expected2 = new List<string> {"Venus"};
            var result2 = compareLogic.Compare(actual2, expected2);
            if (!result2.AreEqual) {throw new Exception("Exception --- test case 1 failed to pass");}

            var actual3 = Bf("Mercury","Uranus");
            var expected3 = new List<string> {"Venus","Earth","Mars","Jupiter","Saturn"};
            var result3 = compareLogic.Compare(actual3, expected3);
            if (!result3.AreEqual) {throw new Exception("Exception --- test case 2 failed to pass");}

            var actual4 = Bf("Neptune","Venus");
            var expected4 = new List<string> {"Earth","Mars","Jupiter","Saturn","Uranus"};
            var result4 = compareLogic.Compare(actual4, expected4);
            if (!result4.AreEqual) {throw new Exception("Exception --- test case 3 failed to pass");}

            var actual5 = Bf("Earth","Earth");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            if (!result5.AreEqual) {throw new Exception("Exception --- test case 4 failed to pass");}

            var actual6 = Bf("Mars","Earth");
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            if (!result6.AreEqual) {throw new Exception("Exception --- test case 5 failed to pass");}

            var actual7 = Bf("Jupiter","Makemake");
            var expected7 = new List<string> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            if (!result7.AreEqual) {throw new Exception("Exception --- test case 6 failed to pass");}

        }
    }
}
```
