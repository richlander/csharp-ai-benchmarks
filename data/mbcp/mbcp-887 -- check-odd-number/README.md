# mbcp-887 -- Check if a number is odd using bitwise operator

## Text

Write a C# function to check whether the given number is odd or not using bitwise operator.

## Code

```csharp
public bool IsOdd(int n) 
{
    if ((n ^ 1) == (n - 1))
    {
        return true; 
    }
    else 
    {
        return false; 
    }
}
```

## Test List

```csharp
Debug.Assert(IsOdd(5) == true);
```

```csharp
Debug.Assert(IsOdd(6) == false);
```

```csharp
Debug.Assert(IsOdd(7) == true);
```
