# mbcp68 -- Check if an array is monotonic in Python

## Text

Write a C# function to check whether the given array is monotonic or not.

## Code

```csharp
public bool IsMonotonic(int[] A) 
{ 
    return (A.Zip(A.Skip(1), (a, b) => a <= b).All(x => x) || 
            A.Zip(A.Skip(1), (a, b) => a >= b).All(x => x)); 
}
```

## Test List

```csharp
Debug.Assert(IsMonotonic(new int[] { 6, 5, 4, 4 }) == true);
```

```csharp
Debug.Assert(IsMonotonic(new int[] { 1, 2, 2, 3 }) == true);
```

```csharp
Debug.Assert(IsMonotonic(new int[] { 1, 3, 2 }) == false);
```
