# mbcp-275 -- Find the position of the last removed array element

## Text

Write a C# function to find the position of the last removed element from the given array.

## Code

```csharp
using System;

public class PositionFinder
{
    public static int GetPosition(int[] a, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            a[i] = (a[i] / m + (a[i] % m != 0 ? 1 : 0));
        }

        int result = -1, maxx = -1;
        for (int i = n - 1; i >= 0; i--)
        {
            if (maxx < a[i])
            {
                maxx = a[i];
                result = i;
            }
        }
        return result + 1;
    }
}
```

## Test List

```csharp
Debug.Assert(GetPosition(new int[] { 2, 5, 4 }, 3, 2) == 2);
```

```csharp
Debug.Assert(GetPosition(new int[] { 4, 3 }, 2, 2) == 2);
```

```csharp
Debug.Assert(GetPosition(new int[] { 1, 2, 3, 4 }, 4, 1) == 4);
```
