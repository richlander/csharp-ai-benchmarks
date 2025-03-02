# mbcp326 -- Find the most frequent word in a list of strings

## Text

Write a function to get the word with most number of occurrences in the given strings list.

## Code

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Example
{
    public static string MostOccurrences(List<string> testList)
    {
        var temp = new Dictionary<string, int>();
        
        foreach (var sub in testList)
        {
            foreach (var wrd in sub.Split(' '))
            {
                if (temp.ContainsKey(wrd))
                {
                    temp[wrd]++;
                }
                else
                {
                    temp[wrd] = 1;
                }
            }
        }
        
        var res = temp.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        return res.ToString();
    }
}
```

## Test List

```csharp
Debug.Assert(MostOccurrences(new string[] { "UTS is best for RTF", "RTF love UTS", "UTS is best" }) == "UTS");
```

```csharp
Debug.Assert(MostOccurrences(new string[] { "Its been a great year", "this year is so worse", "this year is okay" }) == "year");
```

```csharp
Debug.Assert(MostOccurrences(new string[] { "Families can be reunited", "people can be reunited", "Tasks can be achieved " }) == "can");
```
