# mbcp-71 -- Sort a list using the comb sort algorithm

## Text

Write a function to sort a list of elements using comb sort.

## Code

```csharp
public static List<int> CombSort(List<int> nums) {
    double shrinkFact = 1.3;
    int gaps = nums.Count;
    bool swapped = true;
    int i = 0;
    while (gaps > 1 || swapped) {
        gaps = (int)(gaps / shrinkFact);
        swapped = false;
        i = 0;
        while (gaps + i < nums.Count) {
            if (nums[i] > nums[i + gaps]) {
                int temp = nums[i];
                nums[i] = nums[i + gaps];
                nums[i + gaps] = temp;
                swapped = true;
            }
            i++;
        }
    }
    return nums;
}
```

## Test List

```csharp
Debug.Assert(CombSort(new int[] { 5, 15, 37, 25, 79 }).SequenceEqual(new int[] { 5, 15, 25, 37, 79 }));
```

```csharp
Debug.Assert(CombSort(new int[] { 41, 32, 15, 19, 22 }).SequenceEqual(new int[] { 15, 19, 22, 32, 41 }));
```

```csharp
Debug.Assert(CombSort(new int[] { 99, 15, 13, 47 }).SequenceEqual(new int[] { 13, 15, 47, 99 }));
```
