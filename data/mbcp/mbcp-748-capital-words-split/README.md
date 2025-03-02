# mbcp748 -- Insert spaces before capitalized words in a string

## Text

Write a function to put spaces between words starting with capital letters in a given string by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public string CapitalWordsSpaces(string str1)
{
    return Regex.Replace(str1, @"(\w)([A-Z])", "$1 $2");
}
```

## Test List

```csharp
Debug.Assert(CapitalWordsSpaces("Python") == "Python");
```

```csharp
Debug.Assert(CapitalWordsSpaces("PythonProgrammingExamples") == "Python Programming Examples");
```

```csharp
Debug.Assert(CapitalWordsSpaces("GetReadyToBeCodingFreak") == "Get Ready To Be Coding Freak");
```
