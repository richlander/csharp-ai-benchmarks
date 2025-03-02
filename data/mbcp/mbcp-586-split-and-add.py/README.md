# mbcp586 -- Split array and move first part to the end

## Text

Write a C# function to split the array and add the first part to the end.

## Code

```csharp
public static List<int> SplitArr(List<int> a, int n, int k)  
{  
    var b = a.Take(k).ToList();  
    return a.Skip(k).Concat(b).ToList();  
}
```

## Test List

```csharp
Debug.Assert(SplitArr(new int[] { 12, 10, 5, 6, 52, 36 }, 6, 2).SequenceEqual(new int[] { 5, 6, 52, 36, 12, 10 }));
```

```csharp
Debug.Assert(SplitArr(new int[] { 1, 2, 3, 4 }, 4, 1).SequenceEqual(new int[] { 2, 3, 4, 1 }));
```

```csharp
Debug.Assert(SplitArr(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 8, 3).SequenceEqual(new int[] { 3, 4, 5, 6, 7, 0, 1, 2 }));
```
