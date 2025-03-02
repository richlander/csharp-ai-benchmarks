# mbcp476 -- Sum the largest and smallest values in an array

## Text

Write a C# function to find the sum of the largest and smallest value in a given array.

## Code

```csharp
public int BigSum(List<int> nums)
{
    int sum = nums.Max() + nums.Min();
    return sum;
}
```

## Test List

```csharp
Debug.Assert(BigSum(new int[] { 1, 2, 3 }) == 4);
```

```csharp
Debug.Assert(BigSum(new int[] { -1, 2, 3, 4 }) == 3);
```

```csharp
Debug.Assert(BigSum(new int[] { 2, 3, 6 }) == 8);
```
