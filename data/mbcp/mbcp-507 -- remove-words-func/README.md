# mbcp-507 -- Remove specified words from a list with a function

## Text

Write a function to remove specific words from a given list.

## Code

```csharp
public List<string> RemoveWords(List<string> list1, List<string> removeWords)
{
    foreach (var word in new List<string>(list1))
    {
        if (removeWords.Contains(word))
        {
            list1.Remove(word);
        }
    }
    return list1;
}
```

## Test List

```csharp
Debug.Assert(RemoveWords(new List<string> { "red", "green", "blue", "white", "black", "orange" }, new List<string> { "white", "orange" }).SequenceEqual(new List<string> { "red", "green", "blue", "black" }));
```

```csharp
Debug.Assert(RemoveWords(new List<string> { "red", "green", "blue", "white", "black", "orange" }, new List<string> { "black", "orange" }).SequenceEqual(new List<string> { "red", "green", "blue", "white" }));
```

```csharp
Debug.Assert(RemoveWords(new List<string> { "red", "green", "blue", "white", "black", "orange" }, new List<string> { "blue", "white" }).SequenceEqual(new List<string> { "red", "green", "black", "orange" }));
```
