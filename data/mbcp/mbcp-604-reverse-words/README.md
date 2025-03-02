# mbcp604 -- Reverse words in a string with a custom function

## Text

Write a function to reverse words in a given string.

## Code

```csharp
public string ReverseWords(string s) 
{
    return string.Join(" ", s.Split(' ').Reverse());
}
```

## Test List

```csharp
Debug.Assert(ReverseWords("python program") == "program python");
```

```csharp
Debug.Assert(ReverseWords("java language") == "language java");
```

```csharp
Debug.Assert(ReverseWords("indian man") == "man indian");
```
