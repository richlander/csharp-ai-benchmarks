# mbcp870 -- Sum positive numbers in a list using lambda

## Text

Write a function to calculate the sum of the positive numbers of a given list of numbers using lambda function.

## Code

```csharp
public static int SumPositiveNum(List<int> nums) {
    var sumPositiveNum = nums.Where(num => num > 0).ToList();
    return sumPositiveNum.Sum();
}
```

## Test List

```csharp
Debug.Assert(SumPositiveNum(new int[] { 2, 4, -6, -9, 11, -12, 14, -5, 17 }) == 48);
```

```csharp
Debug.Assert(SumPositiveNum(new int[] { 10, 15, -14, 13, -18, 12, -20 }) == 50);
```

```csharp
Debug.Assert(SumPositiveNum(new int[] { 19, -65, 57, 39, 152, -639, 121, 44, 90, -190 }) == 522);
```
