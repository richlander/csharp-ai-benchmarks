# mbcp680 -- Check if a sequence of numbers is increasing

## Text

Write a C# function to check whether a sequence of numbers has an increasing trend or not.

## Code

```csharp
public bool IncreasingTrend(List<int> nums) {
    return nums.SequenceEqual(nums.OrderBy(n => n));
}
```

## Test List

```csharp
Debug.Assert(IncreasingTrend(new int[] { 1, 2, 3, 4 }) == true);
```

```csharp
Debug.Assert(IncreasingTrend(new int[] { 4, 3, 2, 1 }) == false);
```

```csharp
Debug.Assert(IncreasingTrend(new int[] { 0, 1, 4, 9 }) == true);
```
