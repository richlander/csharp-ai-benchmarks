# mbcp-324 -- Sum of alternate tuple chains in a function

## Text

Write a function to extract the sum of alternate chains of tuples.

## Code

```csharp
public static (int, int) SumOfAlternates((int, int)[] testTuple) {
    int sum1 = 0;
    int sum2 = 0;
    for (int idx = 0; idx < testTuple.Length; idx++) {
        if (idx % 2 == 1) {
            sum1 += testTuple[idx].Item1;
        } else {
            sum2 += testTuple[idx].Item1;
        }
    }
    return (sum1, sum2);
}
```

## Test List

```csharp
Debug.Assert(SumOfAlternates(new int[] { 5, 6, 3, 6, 10, 34 }).Equals((46, 18)));
```

```csharp
Debug.Assert(SumOfAlternates(new int[] { 1, 2, 3, 4, 5 }) == (6, 9));
```

```csharp
Debug.Assert(SumOfAlternates(new int[] { 6, 7, 8, 9, 4, 5 }) == (21, 18));
```
