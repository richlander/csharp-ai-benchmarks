# mbcp88 -- Count element frequencies in a list with a function

## Text

Write a function to get the frequency of the elements in a list.

## Code

```csharp
using System.Collections.Generic;

public Dictionary<T, int> FreqCount<T>(List<T> list1)
{
    Dictionary<T, int> freqCount = new Dictionary<T, int>();

    foreach (T item in list1)
    {
        if (freqCount.ContainsKey(item))
        {
            freqCount[item]++;
        }
        else
        {
            freqCount[item] = 1;
        }
    }

    return freqCount;
}
```

## Test List

```csharp
Debug.Assert(FreqCount(new int[] { 10, 10, 10, 10, 20, 20, 20, 20, 40, 40, 50, 50, 30 }).SequenceEqual(new Dictionary<int, int> { { 10, 4 }, { 20, 4 }, { 40, 2 }, { 50, 2 }, { 30, 1 } }));
```

```csharp
Debug.Assert(FreqCount(new int[] { 1, 2, 3, 4, 3, 2, 4, 1, 3, 1, 4 }).SequenceEqual(new Dictionary<int, int> { { 1, 3 }, { 2, 2 }, { 3, 3 }, { 4, 3 } }));
```

```csharp
Debug.Assert(FreqCount(new int[] { 5, 6, 7, 4, 9, 10, 4, 5, 6, 7, 9, 5 }).SequenceEqual(new Dictionary<int, int> { { 10, 1 }, { 5, 3 }, { 6, 2 }, { 7, 2 }, { 4, 2 }, { 9, 2 } }));
```
