# mbcp786 -- Locate insertion point for a value in sorted array

## Text

Write a function to locate the right insertion point for a specified value in sorted order.

## Code

```csharp
using System;
using System.Collections.Generic;

public class Program
{
    public static int RightInsertion(List<int> a, int x)
    {
        return a.BinarySearch(x) >= 0 
            ? a.IndexOf(x, a.BinarySearch(x)) + 1 
            : ~a.BinarySearch(x);
    }
}
```

## Test List

```csharp
Debug.Assert(RightInsertion(new List<int> { 1, 2, 4, 5 }, 6) == 4);
```

```csharp
Debug.Assert(RightInsertion(new int[] { 1, 2, 4, 5 }, 3) == 2);
```

```csharp
Debug.Assert(RightInsertion(new int[] { 1, 2, 4, 5 }, 7) == 4);
```
