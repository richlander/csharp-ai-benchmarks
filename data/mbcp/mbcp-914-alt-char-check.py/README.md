# mbcp914 -- Check if a string contains two alternating characters

## Text

Write a C# function to check whether the given string is made up of two alternating characters or not.

## Code

```csharp
public static bool IsTwoAlter(string s)  
{  
    for (int i = 0; i < s.Length - 2; i++)  
    {  
        if (s[i] != s[i + 2])  
        {  
            return false;  
        }  
    }  
    if (s[0] == s[1])  
    {  
        return false;  
    }  
    return true;  
}
```

## Test List

```csharp
Debug.Assert(IsTwoAlter("abab") == true);
```

```csharp
Debug.Assert(IsTwoAlter("aaaa") == false);
```

```csharp
Debug.Assert(IsTwoAlter("xyz") == false);
```
