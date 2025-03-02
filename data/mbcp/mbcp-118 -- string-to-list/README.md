# mbcp-118 -- Convert a string into a list format

## Text

[link text](https:// [link text](https:// [link text](https://)))write a function to convert a string to a list.

## Code

```csharp
public List<string> StringToList(string input) 
{ 
    List<string> lst = new List<string>(input.Split(' ')); 
    return lst; 
}
```

## Test List

```csharp
Debug.Assert(StringToList("python programming").SequenceEqual(new List<string> { "python", "programming" }));
```

```csharp
Debug.Assert(StringToList("lists tuples strings").SequenceEqual(new List<string> { "lists", "tuples", "strings" }));
```

```csharp
Debug.Assert(StringToList("write a program").SequenceEqual(new List<string> { "write", "a", "program" }));
```
