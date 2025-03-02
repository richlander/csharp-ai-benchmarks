# mbcp809 -- Check if second tuple elements are smaller

## Text

Write a function to check if each element of second tuple is smaller than its corresponding index in first tuple.

## Code

```csharp
public bool CheckSmaller(Tuple<int, int> testTup1, Tuple<int, int> testTup2)
{
    bool res = testTup1.Item1 > testTup2.Item1 && testTup1.Item2 > testTup2.Item2;
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckSmaller(new Tuple<int, int, int>(1, 2, 3), new Tuple<int, int, int>(2, 3, 4)) == false);
```

```csharp
Debug.Assert(CheckSmaller((4, 5, 6), (3, 4, 5)) == true);
```

```csharp
Debug.Assert(CheckSmaller(new int[] { 11, 12, 13 }, new int[] { 10, 11, 12 }) == true);
```
