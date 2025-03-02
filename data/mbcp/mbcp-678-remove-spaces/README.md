# mbcp678 -- Remove spaces from a given string in Python

## Text

Write a C# function to remove spaces from a given string.

## Code

```csharp
public string RemoveSpaces(string str1) 
{
    str1 = str1.Replace(' ', '');
    return str1;
}
```

## Test List

```csharp
Debug.Assert(RemoveSpaces("a b c") == "abc");
```

```csharp
Debug.Assert(RemoveSpaces("1 2 3") == "123");
```

```csharp
Debug.Assert(RemoveSpaces(" b c") == "bc");
```
