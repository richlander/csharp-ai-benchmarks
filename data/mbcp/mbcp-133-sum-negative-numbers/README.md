# mbcp133 -- Sum negative numbers in a list using lambda function

## Text

Write a function to calculate the sum of the negative numbers of a given list of numbers using lambda function.

## Code

```csharp
public int SumNegativenum(List<int> nums) 
{
    var sumNegativenum = nums.Where(num => num < 0).ToList();
    return sumNegativenum.Sum();
}
```

## Test List

```csharp
Debug.Assert(SumNegativenum(new List<int> { 2, 4, -6, -9, 11, -12, 14, -5, 17 }) == -32);
```

```csharp
Debug.Assert(SumNegativenum(new int[] { 10, 15, -14, 13, -18, 12, -20 }) == -52);

public int SumNegativenum(int[] numbers)
{
    return numbers.Where(x => x < 0).Sum();
}
```

```csharp
Debug.Assert(SumNegativenum(new int[] { 19, -65, 57, 39, 152, -639, 121, 44, 90, -190 }) == -894);

public int SumNegativenum(int[] nums) {
    return nums.Where(n => n < 0).Sum();
}
```
