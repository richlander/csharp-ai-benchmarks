# mbcp477 -- Convert a string to lower case in Python

## Text

Write a C# function to convert the given string to lower case.

## Code

```csharp
public string IsLower(string input)
{
    return input.ToLower();
}
```

## Test List

```csharp
Debug.Assert(IsLower("InValid") == "invalid");
```

```csharp
Debug.Assert(IsLower("TruE") == "true");
```

```csharp
Debug.Assert(IsLower("SenTenCE") == "sentence");
```
