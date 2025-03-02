# mbcp456 -- Reverse strings in a list of string values

## Text

Write a function to reverse strings in a given list of string values.

## Code

```csharp
public List<string> ReverseStringList(List<string> stringlist) {
    List<string> result = stringlist.Select(x => new string(x.Reverse().ToArray())).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(ReverseStringList(new List<string> { "Red", "Green", "Blue", "White", "Black" }).SequenceEqual(new List<string> { "deR", "neerG", "eulB", "etihW", "kcalB" }));
```

```csharp
Debug.Assert(ReverseStringList(new List<string> { "john", "amal", "joel", "george" }).SequenceEqual(new List<string> { "nhoj", "lama", "leoj", "egroeg" }));
```

```csharp
Debug.Assert(ReverseStringList(new List<string> { "jack", "john", "mary" }).SequenceEqual(new List<string> { "kcaj", "nhoj", "yram" }));
```
