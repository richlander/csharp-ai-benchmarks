# mbcp-77 -- Calculate even and odd digit sum difference

## Text

Write a C# function to find the difference between sum of even and odd digits.

## Code

```csharp
public bool IsDiff(int n) 
{ 
    return (n % 11 == 0); 
}
```

## Test List

```csharp
Debug.Assert(IsDiff(12345) == false);
```

```csharp
Debug.Assert(IsDiff(1212112) == true);
```

```csharp
Debug.Assert(IsDiff(1212) == false);
```
