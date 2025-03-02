# mbcp-964 -- Check if the word length is even or odd

## Text

Write a C# function to check whether the length of the word is even or not.

## Code

```csharp
public bool WordLen(string s) 
{ 
    var words = s.Split(' '); 
    foreach (var word in words) 
    { 
        if (word.Length % 2 == 0) 
        { 
            return true; 
        } 
        else 
        { 
            return false; 
        } 
    } 
    return false; 
}
```

## Test List

```csharp
Debug.Assert(WordLen("program") == false);
```

```csharp
Debug.Assert(WordLen("solution") == true);
```

```csharp
Debug.Assert(WordLen("data") == true);
```
