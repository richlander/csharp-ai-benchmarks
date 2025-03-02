# mbcp-588 -- Find the difference between max and min in array

## Text

Write a C# function to find the difference between largest and smallest value in a given array.

## Code

```csharp
public int BigDiff(List<int> nums) 
{
    int diff = nums.Max() - nums.Min();
    return diff;
}
```

## Test List

```csharp
Debug.Assert(BigDiff(new int[] { 1, 2, 3, 4 }) == 3);
```

```csharp
Debug.Assert(BigDiff(new int[] { 4, 5, 12 }) == 8);
```

```csharp
Debug.Assert(BigDiff(new int[] { 9, 2, 3 }) == 7);
```
