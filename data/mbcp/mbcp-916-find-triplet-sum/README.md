# mbcp916 -- Find a triplet in an array that sums to a value

## Text

Write a function to find if there is a triplet in the array whose sum is equal to a given value.

## Code

```csharp
public (int, int, int)? FindTripletArray(int[] A, int arrSize, int sum) 
{
    for (int i = 0; i < arrSize - 2; i++) 
    {
        for (int j = i + 1; j < arrSize - 1; j++) 
        {
            for (int k = j + 1; k < arrSize; k++) 
            {
                if (A[i] + A[j] + A[k] == sum) 
                {
                    return (A[i], A[j], A[k]);
                }
            }
        }
    }
    return null;
}
```

## Test List

```csharp
Debug.Assert(FindTripletArray(new int[] { 1, 4, 45, 6, 10, 8 }, 6, 22).SequenceEqual(new int[] { 4, 10, 8 }));
```

```csharp
Debug.Assert(FindTripletArray(new int[] { 12, 3, 5, 2, 6, 9 }, 6, 24).SequenceEqual(new int[] { 12, 3, 9 }));
```

```csharp
Debug.Assert(FindTripletArray(new int[] { 1, 2, 3, 4, 5 }, 5, 9).SequenceEqual(new int[] { 1, 3, 5 }));
```
