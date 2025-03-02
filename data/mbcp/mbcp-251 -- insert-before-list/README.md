# mbcp-251 -- Insert an element before each item in a list

## Text

Write a function to insert an element before each element of a list.

## Code

```csharp
public List<T> InsertElement<T>(List<T> list, T element)
{
    list = list.SelectMany(elt => new[] { element, elt }).ToList();
    return list;
}
```

## Test List

```csharp
Debug.Assert(InsertElement(new List<string> { "Red", "Green", "Black" }, 'c').SequenceEqual(new List<string> { "c", "Red", "c", "Green", "c", "Black" }));
```

```csharp
Debug.Assert(InsertElement(new List<string> { "python", "java" }, "program").SequenceEqual(new List<string> { "program", "python", "program", "java" }));
```

```csharp
Debug.Assert(InsertElement(new string[] { "happy", "sad" }, "laugh").SequenceEqual(new string[] { "laugh", "happy", "laugh", "sad" }));
```
