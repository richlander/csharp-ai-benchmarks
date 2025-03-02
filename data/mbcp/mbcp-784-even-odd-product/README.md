# mbcp784 -- Product of first even and odd numbers in a list

## Text

Write a function to find the product of first even and odd number of a given list.

## Code

```csharp
public int MulEvenOdd(List<int> list1) {
    int firstEven = list1.FirstOrDefault(el => el % 2 == 0);
    int firstOdd = list1.FirstOrDefault(el => el % 2 != 0);
    return firstEven * firstOdd;
}
```

## Test List

```csharp
Debug.Assert(MulEvenOdd(new int[] { 1, 3, 5, 7, 4, 1, 6, 8 }) == 4);
```

```csharp
Debug.Assert(MulEvenOdd(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }) == 2);
```

```csharp
Debug.Assert(MulEvenOdd(new int[] { 1, 5, 7, 9, 10 }) == 10);
```
