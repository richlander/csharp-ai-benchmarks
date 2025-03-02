# mbcp-206 -- Concatenate adjacent elements in tuples

## Text

Write a function to perform the adjacent element concatenation in the given tuples.

## Code

```csharp
public static Tuple<string> ConcatenateElements(Tuple<string> testTup) 
{
    var res = testTup.Zip(testTup.Skip(1), (i, j) => i + j).ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(ConcatenateElements(new Tuple<string, string, string, string, string, string>("DSP ", "IS ", "BEST ", "FOR ", "ALL ", "UTS")) == new Tuple<string, string, string, string, string>("DSP IS ", "IS BEST ", "BEST FOR ", "FOR ALL ", "ALL UTS"));
```

```csharp
Debug.Assert(ConcatenateElements(new Tuple<string, string, string, string, string, string>("RES ", "IS ", "BEST ", "FOR ", "ALL ", "QESR")) == new Tuple<string, string, string, string, string>("RES IS ", "IS BEST ", "BEST FOR ", "FOR ALL ", "ALL QESR"));
```

```csharp
Debug.Assert(ConcatenateElements(("MSAM", "IS ", "BEST ", "FOR ", "ALL ", "SKD")).SequenceEqual(new[] { "MSAMIS ", "IS BEST ", "BEST FOR ", "FOR ALL ", "ALL SKD" }));
```
