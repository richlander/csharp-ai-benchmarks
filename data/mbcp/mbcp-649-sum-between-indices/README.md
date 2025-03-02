# mbcp649 -- Calculate sum of numbers in a specified index range

## Text

Write a C# function to calculate the sum of the numbers in a list between the indices of a specified range.

## Code

```csharp
public int SumRangeList(List<int> nums, int m, int n)  
{  
    int sumRange = 0;  
    for (int i = m; i <= n; i++)  
    {  
        sumRange += nums[i];  
    }  
    return sumRange;  
}
```

## Test List

```csharp
Debug.Assert(SumRangeList(new List<int> { 2, 1, 5, 6, 8, 3, 4, 9, 10, 11, 8, 12 }, 8, 10) == 29);
```

```csharp
Debug.Assert(SumRangeList(new int[] { 1, 2, 3, 4, 5 }, 1, 2) == 5);
```

```csharp
Debug.Assert(SumRangeList(new List<int> { 1, 0, 1, 2, 5, 6 }, 4, 5) == 11);
```
