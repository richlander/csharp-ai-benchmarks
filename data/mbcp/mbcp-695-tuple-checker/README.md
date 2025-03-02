# mbcp695 -- Check if second tuple elements exceed first tuple indices

## Text

Write a function to check if each element of the second tuple is greater than its corresponding index in the first tuple.

## Code

```csharp
public bool CheckGreater(Tuple<int, int> testTup1, Tuple<int, int> testTup2)
{
    bool res = testTup1.Item1 < testTup2.Item1 && testTup1.Item2 < testTup2.Item2;
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckGreater(new int[] { 10, 4, 5 }, new int[] { 13, 5, 18 }) == true);
```

```csharp
Debug.Assert(CheckGreater(new int[] { 1, 2, 3 }, new int[] { 2, 1, 4 }) == false);
```

```csharp
Debug.Assert(CheckGreater(new int[] { 4, 5, 6 }, new int[] { 5, 6, 7 }) == true);
```
