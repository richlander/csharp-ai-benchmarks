# mbcp-639 -- Sum lengths of names excluding those starting lowercase

## Text

Write a function to sum the length of the names of a given list of names after removing the names that start with a lowercase letter.

## Code

```csharp
public int SampleNam(List<string> sampleNames) {
    sampleNames = sampleNames.Where(el => char.IsUpper(el[0]) && el.Substring(1).All(char.IsLower)).ToList();
    return "".Join(sampleNames).Length;
}
```

## Test List

```csharp
Debug.Assert(SampleNam(new List<string> { "sally", "Dylan", "rebecca", "Diana", "Joanne", "keith" }) == 16);
```

```csharp
Debug.Assert(SampleNam(new string[] {"php", "res", "Python", "abcd", "Java", "aaa"}) == 10);
```

```csharp
Debug.Assert(SampleNam(new string[] { "abcd", "Python", "abba", "aba" }) == 6);
```
