# mbcp-864 -- Find palindromes in a list using a lambda function

## Text

Write a function to find palindromes in a given list of strings using lambda function.

## Code

```csharp
public List<string> PalindromeLambda(List<string> texts)
{
    return texts.Where(x => x == new string(x.Reverse().ToArray())).ToList();
}
```

## Test List

```csharp
Debug.Assert(PalindromeLambda(new List<string> { "php", "res", "Python", "abcd", "Java", "aaa" }).SequenceEqual(new List<string> { "php", "aaa" }));

public List<string> PalindromeLambda(List<string> words) {
    return words.Where(w => w.SequenceEqual(w.Reverse())).ToList();
}
```

```csharp
Debug.Assert(PalindromeLambda(new string[] { "abcd", "Python", "abba", "aba" }).SequenceEqual(new string[] { "abba", "aba" }));

IEnumerable<string> PalindromeLambda(string[] inputs)
{
    return inputs.Where(s => s.SequenceEqual(s.Reverse()));
}
```

```csharp
Debug.Assert(PalindromeLambda(new string[] { "abcd", "abbccbba", "abba", "aba" }).SequenceEqual(new List<string> { "abbccbba", "abba", "aba" }));
```
