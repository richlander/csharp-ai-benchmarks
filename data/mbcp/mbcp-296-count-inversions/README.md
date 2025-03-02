# mbcp296 -- Count inversions in an array using Python function

## Text

Write a C# function to count inversions in an array.

## Code

```csharp
public int GetInvCount(int[] arr, int n) 
{
    int invCount = 0;
    for (int i = 0; i < n; i++) 
    {
        for (int j = i + 1; j < n; j++) 
        {
            if (arr[i] > arr[j]) 
            {
                invCount++;
            }
        }
    }
    return invCount;
}
```

## Test List

```csharp
Debug.Assert(GetInvCount(new int[] { 1, 20, 6, 4, 5 }, 5) == 5);
```

```csharp
Debug.Assert(GetInvCount(new int[] { 1, 2, 1 }, 3) == 1);
```

```csharp
Debug.Assert(GetInvCount(new int[] { 1, 2, 5, 6, 1 }, 5) == 3);
```
