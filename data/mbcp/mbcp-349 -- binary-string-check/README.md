# mbcp-349 -- Check if a string is a valid binary string

## Text

Write a C# function to check whether the given string is a binary string or not.

## Code

```csharp
public string Check(string input)
{
    var p = new HashSet<char>(input);
    var s = new HashSet<char> { '0', '1' };
    if (s.SetEquals(p) || p.SetEquals(new HashSet<char> { '0' }) || p.SetEquals(new HashSet<char> { '1' }))
    {
        return "Yes";
    }
    else
    {
        return "No";
    }
}
```

## Test List

```csharp
Debug.Assert(Check("01010101010") == "Yes");
```

```csharp
Debug.Assert(Check("name0") == "No");
```

```csharp
Debug.Assert(Check("101") == "Yes");
```
