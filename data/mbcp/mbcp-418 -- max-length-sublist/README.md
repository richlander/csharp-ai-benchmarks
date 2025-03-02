# mbcp-418 -- Find the longest sublist in a Python list

## Text

Write a C# function to find the sublist having maximum length.

## Code

```csharp
public int Find_Max(List<int> lst) 
{ 
    int maxList = lst.Max(); 
    return maxList; 
}
```

## Test List

```csharp
Debug.Assert(Find_Max(new string[][] { new string[] { "A" }, new string[] { "A", "B" }, new string[] { "A", "B", "C" } }).SequenceEqual(new string[] { "A", "B", "C" }));
```

```csharp
Debug.Assert(Find_Max(new List<List<int>> { new List<int> { 1 }, new List<int> { 1, 2 }, new List<int> { 1, 2, 3 } }).SequenceEqual(new List<int> { 1, 2, 3 }));
```

```csharp
Debug.Assert(Find_Max(new int[][] { new int[] { 1, 1 }, new int[] { 1, 2, 3 }, new int[] { 1, 5, 6, 1 } }).SequenceEqual(new int[] { 1, 5, 6, 1 }));
```
