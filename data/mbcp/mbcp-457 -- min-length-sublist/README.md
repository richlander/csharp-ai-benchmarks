# mbcp-457 -- Find the shortest sublist in a given list

## Text

Write a C# function to find the sublist having minimum length.

## Code

```csharp
public int FindMin(List<int> lst) 
{ 
    int minList = lst.Min(); 
    return minList; 
}
```

## Test List

```csharp
Debug.Assert(FindMin(new int[][] { new int[] { 1 }, new int[] { 1, 2 }, new int[] { 1, 2, 3 } }).SequenceEqual(new int[] { 1 }));
```

```csharp
Debug.Assert(FindMin(new int[][] { new int[] { 1, 1 }, new int[] { 1, 1, 1 }, new int[] { 1, 2, 7, 8 } }).SequenceEqual(new int[] { 1, 1 }));
```

```csharp
Debug.Assert(Enumerable.SequenceEqual(FindMin(new List<List<string>> { new List<string> { "x" }, new List<string> { "x", "y" }, new List<string> { "x", "y", "z" } }), new List<string> { "x" }));
```
