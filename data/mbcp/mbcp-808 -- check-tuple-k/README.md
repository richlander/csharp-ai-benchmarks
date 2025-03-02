# mbcp-808 -- Check if tuples contain the specified k value

## Text

Write a function to check if the given tuples contain the k or not.

## Code

```csharp
public bool CheckK(Tuple<int, int>[] testTup, int K)
{
    bool res = false;
    foreach (var ele in testTup)
    {
        if (ele.Item1 == K || ele.Item2 == K)
        {
            res = true;
            break;
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckK(new int[] { 10, 4, 5, 6, 8 }, 6) == true);
```

```csharp
Debug.Assert(CheckK(new int[] { 1, 2, 3, 4, 5, 6 }, 7) == false);
```

```csharp
Debug.Assert(CheckK(new int[] { 7, 8, 9, 44, 11, 12 }, 11) == true);
```
