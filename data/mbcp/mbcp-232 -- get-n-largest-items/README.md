# mbcp-232 -- Return the n largest items from a dataset

## Text

Write a function to get the n largest items from a dataset.

## Code

```csharp
using System;
using System.Collections.Generic;

public class Program
{
    public static List<int> LargNNum(List<int> list1, int n)
    {
        var largest = new List<int>(list1);
        largest.Sort((a, b) => b.CompareTo(a));
        return largest.GetRange(0, Math.Min(n, largest.Count));
    }
}
```

## Test List

```csharp
Debug.Assert(LargNNum(new List<int> { 10, 20, 50, 70, 90, 20, 50, 40, 60, 80, 100 }, 2).SequenceEqual(new List<int> { 100, 90 }));
```

```csharp
Debug.Assert(LargNNum(new int[] { 10, 20, 50, 70, 90, 20, 50, 40, 60, 80, 100 }, 5).SequenceEqual(new int[] { 100, 90, 80, 70, 60 }));
```

```csharp
Debug.Assert(LargNNum(new List<int> {10, 20, 50, 70, 90, 20, 50, 40, 60, 80, 100}, 3).SequenceEqual(new List<int> {100, 90, 80}));
```
