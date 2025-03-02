# mbcp471 -- Find array multiplication remainder by n

## Text

Write a C# function to find remainder of array multiplication divided by n.

## Code

```csharp
public static int FindRemainder(int[] arr, int lens, int n) 
{ 
    int mul = 1; 
    for (int i = 0; i < lens; i++) 
    { 
        mul = (mul * (arr[i] % n)) % n; 
    } 
    return mul % n; 
}
```

## Test List

```csharp
Debug.Assert(FindRemainder(new int[] { 100, 10, 5, 25, 35, 14 }, 6, 11) == 9);
```

```csharp
Debug.Assert(FindRemainder(new int[] { 1, 1, 1 }, 3, 1) == 0);
```

```csharp
Debug.Assert(FindRemainder(new int[] { 1, 2, 1 }, 3, 2) == 0);
```
