# mbcp-292 -- Calculate the quotient of two numbers in Python

## Text

Write a C# function to find quotient of two numbers.

## Code

```csharp
public int Find(int n, int m)  
{  
    int q = n / m;  
    return q;  
}
```

## Test List

```csharp
Debug.Assert(Find(10, 3) == 3);
```

```csharp
Debug.Assert(Find(4, 2) == 2);
```

```csharp
Debug.Assert(Find(20, 5) == 4);
```
