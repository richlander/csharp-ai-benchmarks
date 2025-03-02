# mbcp-893 -- Get last element from each sublist in Python

## Text

Write a C# function to get the last element of each sublist.

## Code

```csharp
public List<object> Extract(List<List<object>> lst) 
{ 
    return lst.Select(item => item.Last()).ToList(); 
}
```

## Test List

```csharp
Debug.Assert(Extract(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 } }) == new int[] { 3, 5, 9 });
```

```csharp
Debug.Assert(Extract(new List<List<string>> { new List<string> { "x", "y", "z" }, new List<string> { "m" }, new List<string> { "a", "b" }, new List<string> { "u", "v" } }) == new List<string> { "z", "m", "b", "v" });
```

```csharp
Debug.Assert(Extract(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 } })[0] == 3 && Extract(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 } })[1] == 5);
```
