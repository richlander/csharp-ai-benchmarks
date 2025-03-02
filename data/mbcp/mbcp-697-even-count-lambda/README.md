# mbcp697 -- Count even numbers in a list using lambda function

## Text

Write a function to find number of even elements in the given list using lambda function.

## Code

```csharp
public int CountEven(int[] arrayNums) {
    int countEven = arrayNums.Count(x => x % 2 == 0);
    return countEven;
}
```

## Test List

```csharp
Debug.Assert(CountEven(new int[] { 1, 2, 3, 5, 7, 8, 9, 10 }) == 3);
```

```csharp
Debug.Assert(CountEven(new int[] { 10, 15, 14, 13, -18, 12, -20 }) == 5);
```

```csharp
Debug.Assert(CountEven(new int[] { 1, 2, 4, 8, 9 }) == 3);
```
