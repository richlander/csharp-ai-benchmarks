# mbcp22 -- Find the first duplicate in an integer array

## Text

Write a function to find the first duplicate element in a given array of integers.

## Code

```csharp
public int FindFirstDuplicate(int[] nums) 
{
    HashSet<int> numSet = new HashSet<int>();
    int noDuplicate = -1;

    for (int i = 0; i < nums.Length; i++) 
    {
        if (numSet.Contains(nums[i])) 
        {
            return nums[i];
        } 
        else 
        {
            numSet.Add(nums[i]);
        }
    }

    return noDuplicate;
}
```

## Test List

```csharp
Debug.Assert(FindFirstDuplicate(new int[] { 1, 2, 3, 4, 4, 5 }) == 4);
```

```csharp
Debug.Assert(FindFirstDuplicate(new int[] { 1, 2, 3, 4 }) == -1);
```

```csharp
Debug.Assert(FindFirstDuplicate(new int[] { 1, 1, 2, 3, 3, 2, 2 }) == 1);
```
