# mbcp436 -- Print negative numbers from a list in Python

## Text

Write a C# function to print negative numbers in a list.

## Code

```csharp
public int NegNos(List<int> list1) {
    foreach (int num in list1) {
        if (num < 0) {
            return num;
        }
    }
    return 0; // or throw an exception if no negative numbers are found
}
```

## Test List

```csharp
Debug.Assert(NegNos(new int[] { -1, 4, 5, -6 }) == new int[] { -1, -6 });

public int[] NegNos(int[] numbers) {
    return numbers.Where(n => n < 0).ToArray();
}
```

```csharp
Debug.Assert(NegNos(new int[] { -1, -2, 3, 4 }).SequenceEqual(new int[] { -1, -2 }));

public static IEnumerable<int> NegNos(int[] numbers)
{
    return numbers.Where(n => n < 0);
}
```

```csharp
Debug.Assert(NegNos(new int[] {-7, -6, 8, 9}).SequenceEqual(new int[] {-7, -6}));
```
