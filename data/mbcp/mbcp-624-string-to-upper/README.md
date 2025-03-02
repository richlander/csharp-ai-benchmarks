# mbcp624 -- Convert a string to upper case using Python

## Text

Write a C# function to convert the given string to upper case.

## Code

```csharp
public string IsUpper(string input)
{
    return input.ToUpper();
}
```

## Test List

```csharp
Debug.Assert(IsUpper("person") == "PERSON");
```

```csharp
Debug.Assert(IsUpper("final") == "FINAL");
```

```csharp
Debug.Assert(IsUpper("Valid") == "VALID");
```
