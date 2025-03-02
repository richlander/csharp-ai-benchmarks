# mbcp-95 -- Find minimum length of a sublist in Python

## Text

Write a C# function to find the minimum length of sublist.

## Code

```csharp
public int FindMinLength(List<string> lst)  
{  
    int minLength = lst.Min(x => x.Length);  
    return minLength;  
}
```

## Test List

```csharp
Debug.Assert(FindMinLength(new int[][] { new int[] { 1 }, new int[] { 1, 2 } }) == 1);
```

```csharp
Debug.Assert(FindMinLength(new int[][] { new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 } }) == 2);
```

```csharp
Debug.Assert(FindMinLength(new int[][] { new int[] { 3, 3, 3 }, new int[] { 4, 4, 4, 4 } }) == 3);
```
