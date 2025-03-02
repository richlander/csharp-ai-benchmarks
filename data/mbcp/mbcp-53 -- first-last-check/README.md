# mbcp-53 -- Check if the first and last characters match

## Text

Write a C# function to check whether the first and last characters of a given string are equal or not.

## Code

```csharp
public string CheckEquality(string str)
{
    if (str[0] == str[str.Length - 1])
    {
        return "Equal";
    }
    else
    {
        return "Not Equal";
    }
}
```

## Test List

```csharp
Debug.Assert(CheckEquality("abcda") == "Equal");
```

```csharp
Debug.Assert(CheckEquality("ab") == "Not Equal");
```

```csharp
Debug.Assert(CheckEquality("mad") == "Not Equal");
```
