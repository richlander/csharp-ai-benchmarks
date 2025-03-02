# mbcp-537 -- Find the first repeated word in a string

## Text

Write a C# function to find the first repeated word in a given string.

## Code

```csharp
public string FirstRepeatedWord(string str1) {
    HashSet<string> temp = new HashSet<string>();
    foreach (var word in str1.Split(' ')) {
        if (temp.Contains(word)) {
            return word;
        } else {
            temp.Add(word);
        }
    }
    return "None";
}
```

## Test List

```csharp
Debug.Assert(FirstRepeatedWord("ab ca bc ab") == "ab");
```

```csharp
Debug.Assert(FirstRepeatedWord("ab ca bc") == "None");
```

```csharp
Debug.Assert(FirstRepeatedWord("ab ca bc ca ab bc") == "ca");
```
