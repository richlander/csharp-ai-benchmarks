# mbcp683 -- Check if a number is sum of two squares

## Text

Write a C# function to check whether the given number can be represented by sum of two squares or not.

## Code

```csharp
public bool SumSquare(int n) 
{ 
    int i = 1; 
    while (i * i <= n) 
    { 
        int j = 1; 
        while (j * j <= n) 
        { 
            if (i * i + j * j == n) 
            { 
                return true; 
            } 
            j++; 
        } 
        i++; 
    } 
    return false; 
}
```

## Test List

```csharp
Debug.Assert(SumSquare(25) == true);
```

```csharp
Debug.Assert(SumSquare(24) == false);
```

```csharp
Debug.Assert(SumSquare(17) == true);
```
