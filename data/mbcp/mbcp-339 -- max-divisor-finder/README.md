# mbcp-339 -- Find the most frequent divisor in a range

## Text

Write a C# function to find the maximum occuring divisor in an interval.

## Code

```csharp
public int FindDivisor(int x, int y)  
{  
    if (x == y)  
    {  
        return y;  
    }  
    return 2;  
}
```

## Test List

```csharp
Debug.Assert(FindDivisor(2, 2) == 2);
```

```csharp
Debug.Assert(FindDivisor(2, 5) == 2);
```

```csharp
Debug.Assert(FindDivisor(5, 10) == 2);
```
