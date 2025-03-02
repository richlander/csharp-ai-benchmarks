# mbcp-138 -- Check if a number is a sum of non-zero powers of 2

## Text

Write a C# function to check whether the given number can be represented as sum of non-zero powers of 2 or not.

## Code

```csharp
public bool IsSumOfPowersOfTwo(int n) 
{ 
    if (n % 2 == 1) 
    { 
        return false; 
    } 
    else 
    { 
        return true; 
    } 
}
```

## Test List

```csharp
Debug.Assert(IsSumOfPowersOfTwo(10) == true);
```

```csharp
Debug.Assert(IsSumOfPowersOfTwo(7) == false);
```

```csharp
Debug.Assert(IsSumOfPowersOfTwo(14) == true);
```
