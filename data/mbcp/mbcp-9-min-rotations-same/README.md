# mbcp9 -- Find minimum rotations for string match

## Text

Write a C# function to find the minimum number of rotations required to get the same string.

## Code

```csharp
public int FindRotations(string str) 
{ 
    string tmp = str + str; 
    int n = str.Length; 
    for (int i = 1; i <= n; i++) 
    { 
        string substring = tmp.Substring(i, n); 
        if (str == substring) 
        { 
            return i; 
        } 
    } 
    return n; 
}
```

## Test List

```csharp
Debug.Assert(FindRotations("aaaa") == 1);
```

```csharp
Debug.Assert(FindRotations("ab") == 2);
```

```csharp
Debug.Assert(FindRotations("abc") == 3);
```
