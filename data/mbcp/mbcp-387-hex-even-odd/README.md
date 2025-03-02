# mbcp387 -- Check if a hexadecimal number is even or odd

## Text

Write a C# function to check whether the hexadecimal number is even or odd.

## Code

```csharp
public string EvenOrOdd(string N) 
{ 
    int l = N.Length; 
    if (N[l - 1] == '0' || N[l - 1] == '2' || 
        N[l - 1] == '4' || N[l - 1] == '6' || 
        N[l - 1] == '8' || N[l - 1] == 'A' || 
        N[l - 1] == 'C' || N[l - 1] == 'E') 
    { 
        return "Even"; 
    } 
    else 
    { 
        return "Odd"; 
    } 
}
```

## Test List

```csharp
Debug.Assert(EvenOrOdd("AB3454D") == "Odd");
```

```csharp
Debug.Assert(EvenOrOdd("ABC") == "Even");
```

```csharp
Debug.Assert(EvenOrOdd("AAD") == "Odd");
```
