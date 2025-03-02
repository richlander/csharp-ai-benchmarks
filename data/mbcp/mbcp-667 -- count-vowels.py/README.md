# mbcp-667 -- Count vowels in a given string using Python

## Text

Write a C# function to count number of vowels in the string.

## Code

```csharp
public int CheckVow(string inputString, string vowels) 
{
    var final = inputString.Where(each => vowels.Contains(each)).ToList();
    return final.Count;
}
```

## Test List

```csharp
Debug.Assert(CheckVow("corner", "AaEeIiOoUu") == 2);
```

```csharp
Debug.Assert(CheckVow("valid", "AaEeIiOoUu") == 2);
```

```csharp
Debug.Assert(CheckVow('true', "AaEeIiOoUu") == 2);
```
