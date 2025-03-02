# mbcp-686 -- Count occurrences of each element in a list

## Text

Write a function to find the frequency of each element in the given list.

## Code

```csharp
using System;
using System.Collections.Generic;

public class Converter
{
    public static string FreqElement(IEnumerable<int> testTup)
    {
        var res = new Dictionary<int, int>();
        foreach (var ele in testTup)
        {
            if (res.ContainsKey(ele))
            {
                res[ele]++;
            }
            else
            {
                res[ele] = 1;
            }
        }
        return string.Join(", ", res);
    }
}
```

## Test List

```csharp
Debug.Assert(FreqElement(new Tuple<int, int, int, int, int, int, int, int, int>(4, 5, 4, 5, 6, 6, 5, 5, 4)) == "{4: 3, 5: 4, 6: 2}");
```

```csharp
Debug.Assert(FreqElement(new Tuple<int, int, int, int, int, int, int>(7, 8, 8, 9, 4, 7, 6, 5, 4)) == "{7: 2, 8: 2, 9: 1, 4: 2, 6: 1, 5: 1}");
```

```csharp
Debug.Assert(freq_element(new int[] { 1, 4, 3, 1, 4, 5, 2, 6, 2, 7 }) == "{1: 2, 4: 2, 3: 1, 5: 1, 2: 2, 6: 1, 7: 1}");
```
