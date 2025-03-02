# mbcp-265 -- Split a list into chunks of n elements

## Text

Write a function to split a list for every nth element.

## Code

```csharp
List<string> ListSplit(string S, int step) {
    List<string> result = new List<string>();
    for (int i = 0; i < step; i++) {
        result.Add(S.Substring(i, S.Length - i).Split(new[] { S.Substring(0, step) }, StringSplitOptions.None).Skip(i).Select(x => x[0]).ToString());
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(ListSplit(new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n"}, 3).SequenceEqual(new List<List<string>> { new List<string> { "a", "d", "g", "j", "m" }, new List<string> { "b", "e", "h", "k", "n" }, new List<string> { "c", "f", "i", "l" } }));
```

```csharp
Debug.Assert(ListSplit(new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14}, 3).SequenceEqual(new List<List<int>>{ new List<int>{1,4,7,10,13}, new List<int>{2,5,8,11,14}, new List<int>{3,6,9,12} }));
```

```csharp
Debug.Assert(ListSplit(new List<string> { "python", "java", "C", "C++", "DBMS", "SQL" }, 2).SequenceEqual(new List<List<string>> { new List<string> { "python", "C", "DBMS" }, new List<string> { "java", "C++", "SQL" } }));
```
