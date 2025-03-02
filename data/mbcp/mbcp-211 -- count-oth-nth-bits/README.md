# mbcp-211 -- Count numbers with specific bits set in Python

## Text

Write a C# function to count numbers whose oth and nth bits are set.

## Code

```csharp
public int CountNum(int n) 
{ 
    if (n == 1) 
    { 
        return 1; 
    } 
    int count = (int)Math.Pow(2, n - 2); 
    return count; 
}
```

## Test List

```csharp
Debug.Assert(CountNum(2) == 1);
```

```csharp
Debug.Assert(CountNum(3) == 2);
```

```csharp
Debug.Assert(CountNum(1) == 1);
```
