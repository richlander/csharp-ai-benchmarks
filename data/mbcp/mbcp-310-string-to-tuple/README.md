# mbcp310 -- Convert a string into a tuple format

## Text

Write a function to convert a given string to a tuple.

## Code

```csharp
public static ValueTuple<string> StringToTuple(string str1)
{
    var result = Tuple.Create(str1.Where(x => !char.IsWhiteSpace(x)).ToArray());
    return result;
}
```

## Test List

```csharp
Debug.Assert(StringToTuple("python 3.0").Equals(Tuple.Create('p', 'y', 't', 'h', 'o', 'n', '3', '.', '0')));
```

```csharp
Debug.Assert(StringToTuple("item1").SequenceEqual(new char[] { 'i', 't', 'e', 'm', '1' }));
```

```csharp
Debug.Assert(StringToTuple("15.10").Equals(Tuple.Create("1", "5", ".", "1", "0")));
```
