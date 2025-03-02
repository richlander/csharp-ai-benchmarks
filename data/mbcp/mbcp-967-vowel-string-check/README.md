# mbcp967 -- Function to check strings for all vowels

## Text

Write a C# function to accept the strings which contains all vowels.

## Code

```csharp
public string Check(string input) 
{ 
    if (input.ToCharArray().Distinct().Intersect("AEIOUaeiou").Count() >= 5) 
    { 
        return "accepted"; 
    } 
    else 
    { 
        return "not accepted"; 
    } 
}
```

## Test List

```csharp
Debug.Assert(Check("SEEquoiaL") == "accepted");
```

```csharp
Debug.Assert(Check("program") == "not accepted");
```

```csharp
Debug.Assert(Check("fine") == "not accepted");
```
