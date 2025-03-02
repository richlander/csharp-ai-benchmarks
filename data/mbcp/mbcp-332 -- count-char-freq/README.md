# mbcp-332 -- Count character frequency in a given string

## Text

Write a function to count character frequency of a given string.

## Code

```csharp
public Dictionary<char, int> CharFrequency(string str1) {
    Dictionary<char, int> dict = new Dictionary<char, int>();
    foreach (char n in str1) {
        if (dict.ContainsKey(n)) {
            dict[n] += 1;
        } else {
            dict[n] = 1;
        }
    }
    return dict;
}
```

## Test List

```csharp
Debug.Assert(CharFrequency("python").SequenceEqual(new Dictionary<char, int>{{'p', 1}, {'y', 1}, {'t', 1}, {'h', 1}, {'o', 1}, {'n', 1}}));
```

```csharp
Debug.Assert(CharFrequency("program").SequenceEqual(new Dictionary<char, int> { { 'p', 1 }, { 'r', 2 }, { 'o', 1 }, { 'g', 1 }, { 'a', 1 }, { 'm', 1 } }));
```

```csharp
Debug.Assert(CharFrequency("language").SequenceEqual(new Dictionary<char, int>{{'l', 1}, {'a', 2}, {'n', 1}, {'g', 2}, {'u', 1}, {'e', 1}}));
```
