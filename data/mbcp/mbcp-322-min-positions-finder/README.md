# mbcp322 -- Find all indices of minimum values in a list

## Text

Write a function to find all index positions of the minimum values in a given list.

## Code

```csharp
public List<int> PositionMin(List<int> list1) 
{
    int minVal = list1.Min();
    List<int> minResult = new List<int>();

    for (int i = 0; i < list1.Count; i++)
    {
        if (list1[i] == minVal)
        {
            minResult.Add(i);
        }
    }
    
    return minResult;
}
```

## Test List

```csharp
Debug.Assert(PositionMin(new List<int> { 12, 33, 23, 10, 67, 89, 45, 667, 23, 12, 11, 10, 54 }).SequenceEqual(new List<int> { 3, 11 }));
```

```csharp
Debug.Assert(PositionMin(new List<int> { 1, 2, 2, 2, 4, 4, 4, 5, 5, 5, 5 }).SequenceEqual(new List<int> { 0 }));
```

```csharp
Debug.Assert(PositionMin(new int[] { 2, 1, 5, 6, 8, 3, 4, 9, 10, 11, 8, 12 }).SequenceEqual(new int[] { 1 }));
```
