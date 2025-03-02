# mbcp-83 -- Find a character from the sum of string characters

## Text

Write a C# function to find the character made by adding all the characters of the given string.

## Code

```csharp
public char GetChar(string strr)  
{  
    int summ = 0;  
    for (int i = 0; i < strr.Length; i++)  
    {  
        summ += (strr[i] - 'a' + 1);  
    }  
    if (summ % 26 == 0)  
    {  
        return 'z';  
    }  
    else  
    {  
        summ = summ % 26;  
        return (char)('a' + summ - 1);  
    }  
}
```

## Test List

```csharp
Debug.Assert(GetChar("abc") == "f");
```

```csharp
Debug.Assert(GetChar("gfg") == "t");
```

```csharp
Debug.Assert(GetChar("ab") == "c");
```
