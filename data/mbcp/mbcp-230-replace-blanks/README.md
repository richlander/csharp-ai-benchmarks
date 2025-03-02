# mbcp230 -- Replace spaces in a string with a specified character

## Text

Write a function to replace blank spaces with any character in a string.

## Code

```csharp
public string ReplaceBlank(string str1, char character)
{
    string str2 = str1.Replace(' ', character);
    return str2;
}
```

## Test List

```csharp
Debug.Assert(ReplaceBlank("hello people", '@') == "hello@people");
```

```csharp
Debug.Assert(ReplaceBlank("python program language", '$') == "python$program$language");
```

```csharp
Debug.Assert(ReplaceBlank("blank space", "-") == "blank-space");
```
