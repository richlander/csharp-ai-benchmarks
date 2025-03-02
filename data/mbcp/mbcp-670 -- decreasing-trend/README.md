# mbcp-670 -- Check if a sequence of numbers is decreasing

## Text

Write a C# function to check whether a sequence of numbers has a decreasing trend or not.

## Code

```csharp
bool DecreasingTrend(List<int> nums) {
    return nums.SequenceEqual(nums.OrderByDescending(x => x));
}
```

## Test List

```csharp
Debug.Assert(DecreasingTrend(new int[] {-4, -3, -2, -1}) == true);
```

```csharp
Debug.Assert(DecreasingTrend(new int[] { 1, 2, 3 }) == true);
```

```csharp
Debug.Assert(DecreasingTrend(new List<int> { 3, 2, 1 }) == false);
```
