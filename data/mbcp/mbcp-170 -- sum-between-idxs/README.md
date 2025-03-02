# mbcp-170 -- Calculate sum of numbers in a specified index range

## Text

Write a function to find sum of the numbers in a list between the indices of a specified range.

## Code

```csharp
public int SumRangeList(List<int> list1, int m, int n) 
{
    int sumRange = 0;
    for (int i = m; i <= n; i++)
    {
        sumRange += list1[i];
    }
    return sumRange;
}
```

## Test List

```csharp
Debug.Assert(SumRangeList(new List<int> { 2, 1, 5, 6, 8, 3, 4, 9, 10, 11, 8, 12 }, 8, 10) == 29);
```

```csharp
Debug.Assert(SumRangeList(new List<int> { 2, 1, 5, 6, 8, 3, 4, 9, 10, 11, 8, 12 }, 5, 7) == 16);
```

```csharp
Debug.Assert(SumRangeList(new List<int> { 2, 1, 5, 6, 8, 3, 4, 9, 10, 11, 8, 12 }, 7, 10) == 38);
```
