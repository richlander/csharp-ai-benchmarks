# mbcp913 -- Check if a string ends with a number

## Text

Write a function to check for a number at the end of a string.

## Code

```csharp
public static bool EndNum(string str) {
    var text = new Regex(".*[0-9]$");
    return text.IsMatch(str);
}
```

## Test List

```csharp
Debug.Assert(EndNum("abcdef") == false);
```

```csharp
Debug.Assert(EndNum("abcdef7") == true);
```

```csharp
Debug.Assert(EndNum("abc") == false);
```
