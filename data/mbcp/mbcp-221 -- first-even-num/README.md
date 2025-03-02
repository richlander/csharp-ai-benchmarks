# mbcp-221 -- Find the first even number in a list of numbers

## Text

Write a C# function to find the first even number in a given list of numbers.

## Code

```csharp
public int FirstEven(IEnumerable<int> nums)
{
    return nums.FirstOrDefault(el => el % 2 == 0, -1);
}
```

## Test List

```csharp
Debug.Assert(FirstEven(new List<int> { 1, 3, 5, 7, 4, 1, 6, 8 }) == 4);
```

```csharp
Debug.Assert(FirstEven(new int[] { 2, 3, 4 }) == 2);
```

```csharp
Debug.Assert(FirstEven(new int[] { 5, 6, 7 }) == 6);
```
