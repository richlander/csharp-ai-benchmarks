# mbcp-611 -- Find maximum value in nth column of tuples

## Text

Write a function to find the maximum of nth column from the given tuple list.

## Code

```csharp
public static int MaxOfNth(List<List<int>> testList, int N)  
{  
    int res = testList.Max(sub => sub[N]);  
    return res;  
}
```

## Test List

```csharp
Debug.Assert(MaxOfNth(new List<Tuple<int, int, int>> { Tuple.Create(5, 6, 7), Tuple.Create(1, 3, 5), Tuple.Create(8, 9, 19) }, 2) == 19);
```

```csharp
Debug.Assert(MaxOfNth(new[] { (6, 7, 8), (2, 4, 6), (9, 10, 20) }, 1) == 10);
```

```csharp
Debug.Assert(MaxOfNth(new int[,] {{7, 8, 9}, {3, 5, 7}, {10, 11, 21}}, 1) == 11);
```
