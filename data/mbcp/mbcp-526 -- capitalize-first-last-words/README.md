# mbcp-526 -- Capitalize first and last letters of each word

## Text

Write a C# function to capitalize first and last letters of each word of a given string.

## Code

```csharp
public string CapitalizeFirstLastLetters(string str1)
{
    str1 = str1.ToLower();
    string result = "";
    foreach (var word in str1.Split(' '))
    {
        result += word.Substring(0, word.Length - 1) + char.ToUpper(word[word.Length - 1]) + " ";
    }
    return result.TrimEnd();
}
```

## Test List

```csharp
Debug.Assert(CapitalizeFirstLastLetters("python") == "PythoN");
```

```csharp
Debug.Assert(CapitalizeFirstLastLetters("bigdata") == "BigdatA");
```

```csharp
Debug.Assert(CapitalizeFirstLastLetters("Hadoop") == "HadooP");
```
