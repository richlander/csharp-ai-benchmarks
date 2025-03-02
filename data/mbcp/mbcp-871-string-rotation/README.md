# mbcp871 -- Check if two strings are rotations of each other

## Text

Write a C# function to check whether the given strings are rotations of each other or not.

## Code

```csharp
public bool AreRotations(string string1, string string2) 
{ 
    int size1 = string1.Length; 
    int size2 = string2.Length; 
    string temp = ""; 
    if (size1 != size2) 
    { 
        return false; 
    } 
    temp = string1 + string1; 
    if (temp.Contains(string2)) 
    { 
        return true; 
    } 
    else 
    { 
        return false; 
    } 
}
```

## Test List

```csharp
Debug.Assert(AreRotations("abc", "cba") == false);
```

```csharp
Debug.Assert(AreRotations("abcd", "cdba") == false);
```

```csharp
Debug.Assert(AreRotations("abacd", "cdaba") == true);
```
