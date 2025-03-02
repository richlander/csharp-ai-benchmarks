# mbcp503 -- Function to sum consecutive numbers in a list

## Text

Write a function to add consecutive numbers of a given list.

## Code

```csharp
public List<int> AddConsecutiveNums(List<int> nums) 
{
    List<int> result = new List<int>();
    for (int i = 0; i < nums.Count - 1; i++)
    {
        result.Add(nums[i] + nums[i + 1]);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(AddConsecutiveNums(new List<int> { 1, 1, 3, 4, 4, 5, 6, 7 }).SequenceEqual(new List<int> { 2, 4, 7, 8, 9, 11, 13 }));
```

```csharp
Debug.Assert(AddConsecutiveNums(new int[] { 4, 5, 8, 9, 6, 10 }).SequenceEqual(new int[] { 9, 13, 17, 15, 16 }));
```

```csharp
Debug.Assert(AddConsecutiveNums(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).SequenceEqual(new List<int> { 3, 5, 7, 9, 11, 13, 15, 17, 19 }));
```
