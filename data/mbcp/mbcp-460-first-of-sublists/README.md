# mbcp460 -- Get first elements from each sublist in Python

## Text

Write a C# function to get the first element of each sublist.

## Code

```csharp
public List<T> Extract<T>(List<List<T>> lst) 
{ 
    return lst.Select(item => item[0]).ToList(); 
}
```

## Test List

```csharp
Debug.Assert(Extract(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8, 9 } }) == new List<int> { 1, 3, 6 });
```

```csharp
Debug.Assert(Extract(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 } }) == new int[] { 1, 4 });
```

```csharp
Debug.Assert(Extract(new int[][] { new int[] { 9, 8, 1 }, new int[] { 1, 2 } }).SequenceEqual(new int[] { 9, 1 }));
```
