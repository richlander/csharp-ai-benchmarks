# mbcp736 -- Find the left insertion point in sorted order

## Text

Write a function to locate the left insertion point for a specified value in sorted order.

## Code

```csharp
using System.Collections.Generic;

public class Program
{
    public static int LeftInsertion(List<int> a, int x)
    {
        return a.BinarySearch(x) >= 0 ? a.BinarySearch(x) : ~a.BinarySearch(x);
    }
}
```

## Test List

```csharp
Debug.Assert(LeftInsertion(new List<int> { 1, 2, 4, 5 }, 6) == 4);
```

```csharp
Debug.Assert(LeftInsertion(new List<int> { 1, 2, 4, 5 }, 3) == 2);
```

```csharp
Debug.Assert(LeftInsertion(new int[] { 1, 2, 4, 5 }, 7) == 4);
```
