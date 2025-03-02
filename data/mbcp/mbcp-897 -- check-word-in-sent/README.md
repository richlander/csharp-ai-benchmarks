# mbcp-897 -- Check if a word exists in a given sentence

## Text

Write a C# function to check whether the word is present in a given sentence or not.

## Code

```csharp
public bool IsWordPresent(string sentence, string word) 
{
    string[] s = sentence.Split(" ");
    foreach (string i in s) 
    {
        if (i == word) 
        {
            return true;
        }
    }
    return false;
}
```

## Test List

```csharp
Debug.Assert(IsWordPresent("machine learning", "machine") == true);
```

```csharp
Debug.Assert(IsWordPresent("easy", "fun") == false);
```

```csharp
Debug.Assert(IsWordPresent("python language", "code") == false);
```
