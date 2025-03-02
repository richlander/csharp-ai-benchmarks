# mbcp-502 -- Function to calculate the remainder of two numbers

## Text

Write a C# function to find remainder of two numbers.

## Code

```csharp
public int Find(int n, int m)  
{  
    int r = n % m;  
    return r;  
}
```

## Test List

```csharp
Debug.Assert(Find(3, 3) == 0);
```

```csharp
Debug.Assert(Find(10, 3) == 1);
```

```csharp
Debug.Assert(Find(16, 5) == 1);
```
