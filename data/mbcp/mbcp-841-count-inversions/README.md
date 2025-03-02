# mbcp841 -- Count inversions in an array with a function

## Text

Write a function to count the number of inversions in the given array.

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
Debug.Assert(GetInvCount(new int[] { 8, 4, 2, 1 }, 4) == 6);
```

```csharp
Debug.Assert(GetInvCount(new int[] { 3, 1, 2 }, 3) == 2);
```
