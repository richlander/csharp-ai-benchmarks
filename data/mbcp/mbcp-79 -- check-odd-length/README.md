# mbcp-79 -- Check if a word's length is odd or even

## Text

Write a C# function to check whether the length of the word is odd or not.

## Code

```csharp
public bool WordLen(string s) 
{ 
    string[] words = s.Split(' '); 
    foreach (string word in words) 
    { 
        if (word.Length % 2 != 0) 
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
Debug.Assert(WordLen("Hadoop") == false);
```

```csharp
Debug.Assert(WordLen("great") == true);
```

```csharp
Debug.Assert(WordLen("structure") == true);
```
