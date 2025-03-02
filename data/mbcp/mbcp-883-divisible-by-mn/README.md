# mbcp883 -- Find numbers divisible by m and n using lambda

## Text

Write a function to find numbers divisible by m and n from a list of numbers using lambda function.

## Code

```csharp
public List<int> DivOfNums(List<int> nums, int m, int n)  
{  
    return nums.Where(x => (x % m == 0 && x % n == 0)).ToList();  
}
```

## Test List

```csharp
Debug.Assert(DivOfNums(new int[] { 19, 65, 57, 39, 152, 639, 121, 44, 90, 190 }, 2, 4).SequenceEqual(new int[] { 152, 44 }));
```

```csharp
Debug.Assert(DivOfNums(new List<int> { 1, 2, 3, 5, 7, 8, 10 }, 2, 5).SequenceEqual(new List<int> { 10 }));
```

```csharp
Debug.Assert(DivOfNums(new int[] { 10, 15, 14, 13, 18, 12, 20 }, 10, 5).SequenceEqual(new int[] { 10, 20 }));
```
