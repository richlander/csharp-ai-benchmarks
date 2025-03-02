# mbcp-258 -- Count odd elements in a list using lambda function

## Text

Write a function to find number of odd elements in the given list using lambda function.

## Code

```csharp
public int CountOdd(int[] arrayNums) {
    int countOdd = arrayNums.Count(x => x % 2 != 0);
    return countOdd;
}
```

## Test List

```csharp
Debug.Assert(CountOdd(new int[] { 1, 2, 3, 5, 7, 8, 10 }) == 4);
```

```csharp
Debug.Assert(CountOdd(new int[] { 10, 15, 14, 13, -18, 12, -20 }) == 2);
```

```csharp
Debug.Assert(CountOdd(new int[] { 1, 2, 4, 8, 9 }) == 2);
```
