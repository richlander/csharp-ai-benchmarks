# mbcp8 -- Square elements in a list with a lambda function

## Text

Write a function to find squares of individual elements in a list using lambda function.

## Code

```csharp
public List<int> SquareNums(List<int> nums) 
{
    var squareNums = nums.Select(x => x * x).ToList();
    return squareNums;
}
```

## Test List

```csharp
Debug.Assert(SquareNums(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).SequenceEqual(new int[] { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 }));
```

```csharp
Debug.Assert(SquareNums(new int[] { 10, 20, 30 }).SequenceEqual(new int[] { 100, 400, 900 }));
```

```csharp
Debug.Assert(SquareNums(new int[] { 12, 15 }).SequenceEqual(new int[] { 144, 225 }));
```
