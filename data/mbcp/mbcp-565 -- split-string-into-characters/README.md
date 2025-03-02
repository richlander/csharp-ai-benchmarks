# mbcp-565 -- Function to split a string into individual characters

## Text

Write a C# function to split a string into characters.

## Code

```csharp
public List<char> Split(string word) 
{ 
    return word.ToCharArray().ToList(); 
}
```

## Test List

```csharp
Debug.Assert(Split("python").SequenceEqual(new List<char> { 'p', 'y', 't', 'h', 'o', 'n' }));
```

```csharp
Debug.Assert(Split("Name").SequenceEqual(new[] { 'N', 'a', 'm', 'e' }));
```

```csharp
Debug.Assert(Split("program").SequenceEqual(new char[] { 'p', 'r', 'o', 'g', 'r', 'a', 'm' }));
```
