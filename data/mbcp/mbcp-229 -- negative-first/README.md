# mbcp-229 -- Rearrange array to place negatives before positives

## Text

Write a function to re-arrange the elements of the given array so that all negative elements appear before positive ones.

## Code

```csharp
public int[] ReArrangerArray(int[] arr, int n)
{
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] < 0)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            j++;
        }
    }
    return arr;
}
```

## Test List

```csharp
Debug.Assert(ReArrangerArray(new int[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 }, 9).SequenceEqual(new int[] { -1, -3, -7, 4, 5, 6, 2, 8, 9 }));
```

```csharp
Debug.Assert(ReArrangerArray(new int[] { 12, -14, -26, 13, 15 }, 5).SequenceEqual(new int[] { -14, -26, 12, 13, 15 }));
```

```csharp
Debug.Assert(ReArrangerArray(new int[] { 10, 24, 36, -42, -39, -78, 85 }, 7).SequenceEqual(new int[] { -42, -39, -78, 10, 24, 36, 85 }));
```
