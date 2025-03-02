# mbcp651 -- Check if one tuple is a subset of another tuple

## Text

Write a function to check if one tuple is a subset of another tuple.

## Code

```csharp
public bool CheckSubset(Tuple<int>[] testTup1, Tuple<int>[] testTup2) 
{
    var res = new HashSet<Tuple<int>>(testTup2).IsSubsetOf(testTup1);
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckSubset(new int[] { 10, 4, 5, 6 }, new int[] { 5, 10 }) == true);
```

```csharp
Debug.Assert(CheckSubset(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6 }) == false);
```

```csharp
Debug.Assert(CheckSubset(new int[] { 7, 8, 9, 10 }, new int[] { 10, 8 }) == true);
```
