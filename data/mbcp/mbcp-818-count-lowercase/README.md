# mbcp818 -- Count lowercase letters in a string with Python

## Text

Write a C# function to count lower case letters in a given string.

## Code

```csharp
public int LowerCtr(string str)  
{  
    int lowerCtr = 0;  
    for (int i = 0; i < str.Length; i++)  
    {  
        if (str[i] >= 'a' && str[i] <= 'z')  
        {  
            lowerCtr++;  
        }  
    }  
    return lowerCtr;  
}
```

## Test List

```csharp
Debug.Assert(LowerCtr("abc") == 3);
```

```csharp
Debug.Assert(LowerCtr("string") == 6);
```

```csharp
Debug.Assert(LowerCtr("Python") == 5);
```
