# mbcp-128 -- Shortlist words longer than n from a list

## Text

Write a function to shortlist words that are longer than n from a given list of words.

## Code

```csharp
public List<string> LongWords(int n, string str) {
    List<string> wordLen = new List<string>();
    string[] txt = str.Split(" ");
    foreach (string x in txt) {
        if (x.Length > n) {
            wordLen.Add(x);
        }
    }
    return wordLen;
}
```

## Test List

```csharp
Debug.Assert(LongWords(3, "python is a programming language").SequenceEqual(new List<string> { "python", "programming", "language" }));
```

```csharp
Debug.Assert(LongWords(2, "writing a program").SequenceEqual(new List<string> { "writing", "program" }));
```

```csharp
Debug.Assert(LongWords(5, "sorting list").SequenceEqual(new List<string> { "sorting" }));
```
