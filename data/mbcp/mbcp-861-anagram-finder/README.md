# mbcp861 -- Find anagrams of a string in a list using lambda

## Text

Write a function to find all anagrams of a string in a given list of strings using lambda function.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    public List<string> AnagramLambda(List<string> texts, string str)
    {
        return texts.Where(x => x.Count(c => str.Contains(c)) == str.Length && str.Length == x.Length && x.All(c => str.Count(d => d == c) == x.Count(d => d == c)).ToList()).ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(AnagramLambda(new string[] { "bcda", "abce", "cbda", "cbea", "adcb" }, "abcd").SequenceEqual(new List<string> { "bcda", "cbda", "adcb" }));

public List<string> AnagramLambda(string[] words, string target)
{
    // Method implementation here
}
```

```csharp
Debug.Assert(AnagramLambda(new List<string> { "recitals", " python" }, "articles").SequenceEqual(new List<string> { "recitals" }));
```

```csharp
Debug.Assert(AnagramLambda(new List<string> { " keep", " abcdef", " xyz" }, " peek").SequenceEqual(new List<string> { " keep" }));

public List<string> AnagramLambda(List<string> words, string target) {
    // Method implementation goes here
}
```
