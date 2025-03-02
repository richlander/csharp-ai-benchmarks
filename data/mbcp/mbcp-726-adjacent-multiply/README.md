# mbcp726 -- Multiply adjacent elements in a tuple

## Text

Write a function to multiply the adjacent elements of the given tuple.

## Code

```csharp
public static Tuple<int, int>[] MultiplyElements(Tuple<int, int>[] testTup) 
{
    var res = testTup.Zip(testTup.Skip(1), (i, j) => i * j).ToArray();
    return res;
}
```

## Test List

```csharp
Debug.Assert(MultiplyElements(new int[] { 1, 5, 7, 8, 10 }).SequenceEqual(new int[] { 5, 35, 56, 80 }));
```

```csharp
Debug.Assert(MultiplyElements(new int[] { 2, 4, 5, 6, 7 }).SequenceEqual(new int[] { 8, 20, 30, 42 }));
```

```csharp
Debug.Assert(MultiplyElements(new Tuple<int, int, int, int, int>(12, 13, 14, 9, 15)).Item1 == 156 && MultiplyElements(new Tuple<int, int, int, int, int>(12, 13, 14, 9, 15)).Item2 == 182 && MultiplyElements(new Tuple<int, int, int, int, int>(12, 13, 14, 9, 15)).Item3 == 126 && MultiplyElements(new Tuple<int, int, int, int, int>(12, 13, 14, 9, 15)).Item4 == 135);
```
