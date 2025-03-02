# mbcp-461 -- Count upper case letters in a string with Python

## Text

Write a C# function to count the upper case characters in a given string.

## Code

```csharp
public static int UpperCtr(string str)
{
    int upperCtr = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] >= 'A' && str[i] <= 'Z') upperCtr++;
    }
    return upperCtr;
}
```

## Test List

```csharp
Debug.Assert(UpperCtr("PYthon") == 1);
```

```csharp
Debug.Assert(UpperCtr("BigData") == 1);
```

```csharp
Debug.Assert(UpperCtr("program") == 0);
```
