# mbcp57 -- Find the largest number from given digits

## Text

Write a C# function to find the largest number that can be formed with the given digits.

## Code

```csharp
public long FindMaxNum(int[] arr, int n) 
{ 
    Array.Sort(arr);
    Array.Reverse(arr);
    long num = arr[0]; 
    for (int i = 1; i < n; i++) 
    { 
        num = num * 10 + arr[i]; 
    } 
    return num; 
}
```

## Test List

```csharp
Debug.Assert(FindMaxNum(new int[] { 1, 2, 3 }, 3) == 321);
```

```csharp
Debug.Assert(FindMaxNum(new int[] { 4, 5, 6, 1 }, 4) == 6541);
```

```csharp
Debug.Assert(FindMaxNum(new int[] { 1, 2, 3, 9 }, 4) == 9321);
```
