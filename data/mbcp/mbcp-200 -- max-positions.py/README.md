# mbcp-200 -- Find indices of maximum values in a list

## Text

Write a function to find all index positions of the maximum values in a given list.

## Code

```csharp
public List<int> PositionMax(List<int> list1) 
{
    int maxVal = list1.Max();
    List<int> maxResult = new List<int>();
    for (int i = 0; i < list1.Count; i++) 
    {
        if (list1[i] == maxVal) 
        {
            maxResult.Add(i);
        }
    }
    return maxResult;
}
```

## Test List

```csharp
Debug.Assert(PositionMax(new List<int> { 12, 33, 23, 10, 67, 89, 45, 667, 23, 12, 11, 10, 54 }).SequenceEqual(new List<int> { 7 }));
```

```csharp
Debug.Assert(PositionMax(new int[] { 1, 2, 2, 2, 4, 4, 4, 5, 5, 5, 5 }).SequenceEqual(new int[] { 7, 8, 9, 10 }));
```

```csharp
Debug.Assert(PositionMax(new int[] { 2, 1, 5, 6, 8, 3, 4, 9, 10, 11, 8, 12 }).SequenceEqual(new int[] { 11 }));
```
