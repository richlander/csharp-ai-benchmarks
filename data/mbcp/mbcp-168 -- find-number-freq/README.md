# mbcp-168 -- Count occurrences of a number in an array

## Text

Write a C# function to find the frequency of a number in a given array.

## Code

```csharp
public int Frequency(List<int> a, int x) 
{ 
    int count = 0; 
    foreach (int i in a) 
    { 
        if (i == x) count++; 
    } 
    return count; 
}
```

## Test List

```csharp
Debug.Assert(Frequency(new int[] { 1, 2, 3 }, 4) == 0);
```

```csharp
Debug.Assert(Frequency(new int[] { 1, 2, 2, 3, 3, 3, 4 }, 3) == 3);
```

```csharp
Debug.Assert(Frequency(new int[] { 0, 1, 2, 3, 1, 2 }, 1) == 2);
```
