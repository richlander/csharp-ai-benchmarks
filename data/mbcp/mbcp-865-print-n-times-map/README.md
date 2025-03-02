# mbcp865 -- Print a list n times using the map function

## Text

Write a function to print n-times a list using map function.

## Code

```csharp
public static List<int> NtimesList(IEnumerable<int> nums, int n)  
{  
    return nums.Select(x => n * x).ToList();  
}
```

## Test List

```csharp
Debug.Assert(NtimesList(new List<int> { 1, 2, 3, 4, 5, 6, 7 }, 3).SequenceEqual(new List<int> { 3, 6, 9, 12, 15, 18, 21 }));
```

```csharp
Debug.Assert(NtimesList(new List<int> { 1, 2, 3, 4, 5, 6, 7 }, 4).SequenceEqual(new List<int> { 4, 8, 12, 16, 20, 24, 28 }));
```

```csharp
Debug.Assert(ntimes_list(new List<int> { 1, 2, 3, 4, 5, 6, 7 }, 10).SequenceEqual(new List<int> { 10, 20, 30, 40, 50, 60, 70 }));
```
