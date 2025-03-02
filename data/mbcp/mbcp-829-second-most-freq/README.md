# mbcp829 -- Find the second most frequent string in a list

## Text

Write a function to find out the second most repeated (or frequent) string in the given sequence.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static char SecondFrequent(string input)
    {
        var dict = input.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var value = dict.Values.OrderByDescending(v => v).ToList();
        var secondLarge = value[1];

        foreach (var kvp in dict)
        {
            if (kvp.Value == secondLarge)
            {
                return kvp.Key;
            }
        }
        
        return default;
    }
}
```

## Test List

```csharp
Debug.Assert(SecondFrequent(new string[] { "aaa", "bbb", "ccc", "bbb", "aaa", "aaa" }) == "bbb");
```

```csharp
Debug.Assert(SecondFrequent(new List<string> { "abc", "bcd", "abc", "bcd", "bcd", "bcd" }) == "abc");
```

```csharp
Debug.Assert(SecondFrequent(new List<string> { "cdma", "gsm", "hspa", "gsm", "cdma", "cdma" }) == "gsm");
```
