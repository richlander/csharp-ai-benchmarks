# mbcp-562 -- Find longest sublist length in a given list

## Text

Write a C# function to find the maximum length of sublist.

## Code

```csharp
public static int FindMaxLength(List<string> lst)  
{  
    int maxLength = lst.Max(x => x.Length);  
    return maxLength;  
}
```

## Test List

```csharp
Debug.Assert(FindMaxLength(new List<List<int>> { new List<int> { 1 }, new List<int> { 1, 4 }, new List<int> { 5, 6, 7, 8 } }) == 4);
```

```csharp
Debug.Assert(FindMaxLength(new int[][] { new int[] { 0, 1 }, new int[] { 2, 2 }, new int[] { 3, 2, 1 } }) == 3);
```

```csharp
Debug.Assert(FindMaxLength(new List<List<int>> { new List<int> { 7 }, new List<int> { 22, 23 }, new List<int> { 13, 14, 15 }, new List<int> { 10, 20, 30, 40, 50 } }) == 5);
```
