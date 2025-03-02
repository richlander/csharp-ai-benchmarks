# mbcp-708 -- Convert a string into a list using Python

## Text

Write a C# function to convert a string to a list.

## Code

```csharp
public List<string> Convert(string input) 
{ 
    List<string> li = new List<string>(input.Split(' ')); 
    return li; 
}
```

## Test List

```csharp
Debug.Assert(Convert("python program").SequenceEqual(new List<string> { "python", "program" }));
```

```csharp
Debug.Assert(Convert("Data Analysis").SequenceEqual(new[] { "Data", "Analysis" }));
```

```csharp
Debug.Assert(Convert("Hadoop Training").SequenceEqual(new[] { "Hadoop", "Training" }));
```
