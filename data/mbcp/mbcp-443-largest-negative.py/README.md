# mbcp443 -- Find the largest negative number in a list

## Text

Write a C# function to find the largest negative number from the given list.

## Code

```csharp
public static int LargestNeg(List<int> list1) 
{ 
    int max = list1[0]; 
    foreach (int x in list1) 
    { 
        if (x < max) 
        { 
            max = x; 
        } 
    } 
    return max; 
}
```

## Test List

```csharp
Debug.Assert(LargestNeg(new int[] { 1, 2, 3, -4, -6 }) == -6);
```

```csharp
Debug.Assert(LargestNeg(new int[] { 1, 2, 3, -8, -9 }) == -9);
```

```csharp
Debug.Assert(LargestNeg(new int[] { 1, 2, 3, 4, -1 }) == -1);
```
