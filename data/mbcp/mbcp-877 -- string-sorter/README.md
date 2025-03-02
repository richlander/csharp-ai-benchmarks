# mbcp-877 -- Sort the characters in the given string using Python

## Text

Write a C# function to sort the given string.

## Code

```csharp
public string SortString(string str) 
{ 
    str = string.Concat(str.OrderBy(c => c)); 
    return str; 
}
```

## Test List

```csharp
Debug.Assert(SortString("cba") == "abc");
```

```csharp
Debug.Assert(SortString("data") == "aadt");
```

```csharp
Debug.Assert(SortString("zxy") == "xyz");
```
