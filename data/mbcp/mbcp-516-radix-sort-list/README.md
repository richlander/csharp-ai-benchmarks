# mbcp516 -- Radix sort function for sorting a list of elements

## Text

Write a function to sort a list of elements using radix sort.

## Code

```csharp
public List<int> RadixSort(List<int> nums) 
{
    const int RADIX = 10;
    int placement = 1;
    int maxDigit = nums.Max();

    while (placement < maxDigit) 
    {
        List<List<int>> buckets = new List<List<int>>();
        for (int i = 0; i < RADIX; i++) 
        {
            buckets.Add(new List<int>());
        }
        
        foreach (int i in nums) 
        {
            int tmp = (i / placement) % RADIX;
            buckets[tmp].Add(i);
        }

        int a = 0;
        for (int b = 0; b < RADIX; b++) 
        {
            List<int> buck = buckets[b];
            foreach (int i in buck) 
            {
                nums[a] = i;
                a++;
            }
        }
        placement *= RADIX;
    }
    return nums;
}
```

## Test List

```csharp
Debug.Assert(RadixSort(new int[] { 15, 79, 25, 68, 37 }).SequenceEqual(new int[] { 15, 25, 37, 68, 79 }));
```

```csharp
Debug.Assert(RadixSort(new int[] { 9, 11, 8, 7, 3, 2 }).SequenceEqual(new int[] { 2, 3, 7, 8, 9, 11 }));
```

```csharp
Debug.Assert(RadixSort(new int[] { 36, 12, 24, 26, 29 }) == new int[] { 12, 24, 26, 29, 36 });
```
