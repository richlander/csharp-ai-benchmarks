# mbcp-131 -- Reverse the vowels in a given string using Python

## Text

Write a C# function to reverse only the vowels of a given string.

## Code

```csharp
public string ReverseVowels(string str1)
{
    string vowels = "";
    foreach (char c in str1)
    {
        if ("aeiouAEIOU".Contains(c))
        {
            vowels += c;
        }
    }
    string resultString = "";
    foreach (char c in str1)
    {
        if ("aeiouAEIOU".Contains(c))
        {
            resultString += vowels[vowels.Length - 1];
            vowels = vowels.Substring(0, vowels.Length - 1);
        }
        else
        {
            resultString += c;
        }
    }
    return resultString;
}
```

## Test List

```csharp
Debug.Assert(ReverseVowels("Python") == "Python");
```

```csharp
Debug.Assert(ReverseVowels("USA") == "ASU");
```

```csharp
Debug.Assert(ReverseVowels("ab") == "ab");
```
