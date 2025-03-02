# mbcp130 -- Find the most frequent item in a list

## Text

Write a function to find the item with maximum frequency in a given list.

## Code

```csharp
using System.Collections.Generic;

public Tuple<int, int> MaxOccurrences(List<int> nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    foreach (var i in nums)
    {
        if (dict.ContainsKey(i))
        {
            dict[i]++;
        }
        else
        {
            dict[i] = 1;
        }
    }

    int maxKey = 0;
    int maxValue = 0;
    foreach (var kvp in dict)
    {
        if (kvp.Value > maxValue)
        {
            maxValue = kvp.Value;
            maxKey = kvp.Key;
        }
    }
    return Tuple.Create(maxKey, maxValue);
}
```

## Test List

```csharp
Debug.Assert(MaxOccurrences(new int[] { 2, 3, 8, 4, 7, 9, 8, 2, 6, 5, 1, 6, 1, 2, 3, 2, 4, 6, 9, 1, 2 }) == (2, 5));
```

```csharp
Debug.Assert(MaxOccurrences(new int[] { 2, 3, 8, 4, 7, 9, 8, 7, 9, 15, 14, 10, 12, 13, 16, 16, 18 }) == (8, 2));
```

```csharp
Debug.Assert(MaxOccurrences(new int[] { 10, 20, 20, 30, 40, 90, 80, 50, 30, 20, 50, 10 }) == (20, 3));
```
