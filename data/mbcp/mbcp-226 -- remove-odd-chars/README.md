# mbcp-226 -- Remove characters at odd indices from a string

## Text

Write a C# function to remove the characters which have odd index values of a given string.

## Code

```csharp
public string OddValuesString(string str) 
{
    string result = ""; 
    for (int i = 0; i < str.Length; i++) 
    {
        if (i % 2 == 0) 
        {
            result += str[i];
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(OddValuesString("abcdef") == "ace");
```

```csharp
Debug.Assert(OddValuesString("python") == "pto");
```

```csharp
Debug.Assert(OddValuesString("data") == "dt");
```
