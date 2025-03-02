# mbcp390 -- Insert a string at the start of list items

## Text

Write a function to insert a given string at the beginning of all items in a list.

## Code

```csharp
public List<string> AddString(List<string> list, string inputString)
{
    List<string> addString = list.Select(i => string.Format(inputString, i)).ToList();
    return addString;
}
```

## Test List

```csharp
Debug.Assert(AddString(new int[] { 1, 2, 3, 4 }, "temp{0}") == new string[] { "temp1", "temp2", "temp3", "temp4" });
```

```csharp
Debug.Assert(AddString(new string[] { "a", "b", "c", "d" }, "python{0}").SequenceEqual(new string[] { "pythona", "pythonb", "pythonc", "pythond" }));

public static List<string> AddString(string[] input, string format) {
    return input.Select(s => string.Format(format, s)).ToList();
}
```

```csharp
Debug.Assert(AddString(new int[] { 5, 6, 7, 8 }, "string{0}") == new string[] { "string5", "string6", "string7", "string8" });
```
