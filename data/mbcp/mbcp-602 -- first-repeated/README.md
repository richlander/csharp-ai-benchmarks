# mbcp-602 -- Find the first repeated character in a string

## Text

Write a C# function to find the first repeated character in a given string.

## Code

```csharp
public string FirstRepeatedChar(string str1)
{
    for (int index = 0; index < str1.Length; index++)
    {
        char c = str1[index];
        if (str1.Substring(0, index + 1).Count(x => x == c) > 1)
        {
            return c.ToString();
        }
    }
    return "None";
}
```

## Test List

```csharp
Debug.Assert(FirstRepeatedChar("abcabc") == "a");
```

```csharp
Debug.Assert(FirstRepeatedChar("abc") == "None");
```

```csharp
Debug.Assert(FirstRepeatedChar("123123") == "1");
```
