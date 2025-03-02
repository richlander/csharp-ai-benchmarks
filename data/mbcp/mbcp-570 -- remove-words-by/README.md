# mbcp-570 -- Remove words with specific characters from list

## Text

Write a function to remove words from a given list of strings containing a character or string.

## Code

```csharp
public List<string> RemoveWords(List<string> list1, List<string> charlist) {
    List<string> newList = new List<string>();
    foreach (string line in list1) {
        string newWords = string.Join(" ", line.Split().Where(word => !charlist.Any(phrase => word.Contains(phrase))));
        newList.Add(newWords);
    }
    return newList;
}
```

## Test List

```csharp
Debug.Assert(RemoveWords(new List<string> { "Red color", "Orange#", "Green", "Orange @", "White" }, new List<string> { "#", "color", "@" }).SequenceEqual(new List<string> { "Red", "", "Green", "Orange", "White" }));
```

```csharp
Debug.Assert(RemoveWords(new List<string> { "Red &", "Orange+", "Green", "Orange @", "White" }, new List<string> { "&", "+", "@" }).SequenceEqual(new List<string> { "Red", "", "Green", "Orange", "White" }));
```

```csharp
Debug.Assert(RemoveWords(new List<string> { "Red &", "Orange+", "Green", "Orange @", "White" }, new List<string> { "@" }).SequenceEqual(new List<string> { "Red &", "Orange+", "Green", "Orange", "White" }));
```
