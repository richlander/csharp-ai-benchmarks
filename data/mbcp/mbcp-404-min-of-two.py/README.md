# mbcp404 -- Find the minimum of two numbers in Python

## Text

Write a C# function to find the minimum of two numbers.

## Code

```csharp
public int Minimum(int a, int b)   
{   
    if (a <= b)   
    {   
        return a;   
    }   
    else   
    {   
        return b;   
    }   
}
```

## Test List

```csharp
Debug.Assert(Minimum(1, 2) == 1);
```

```csharp
Debug.Assert(Minimum(-5, -4) == -5);
```

```csharp
Debug.Assert(Minimum(0, 0) == 0);
```
