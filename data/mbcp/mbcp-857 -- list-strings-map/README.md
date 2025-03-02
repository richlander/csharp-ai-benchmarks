# mbcp-857 -- List strings individually using the map function

## Text

Write a function to list out the list of given strings individually using map function.

## Code

```csharp
public List<List<object>> ListifyList(List<object> list1) 
{
    return list1.Select(item => item as List<object>).ToList();
}
```

## Test List

```csharp
Debug.Assert(ListifyList(new List<string> { "Red", "Blue", "Black", "White", "Pink" }).SequenceEqual(new List<List<char>> { 
    new List<char> { 'R', 'e', 'd' }, 
    new List<char> { 'B', 'l', 'u', 'e' }, 
    new List<char> { 'B', 'l', 'a', 'c', 'k' }, 
    new List<char> { 'W', 'h', 'i', 't', 'e' }, 
    new List<char> { 'P', 'i', 'n', 'k' } }));
```

```csharp
Debug.Assert(ListifyList(new List<string> { "python" }).SequenceEqual(new List<List<char>> { new List<char> { 'p', 'y', 't', 'h', 'o', 'n' } }));
```

```csharp
Debug.Assert(ListifyList(new List<string> { " red ", "green", " black", "blue ", " orange", "brown" }).SequenceEqual(new List<List<char>> { 
    new List<char> { ' ', 'r', 'e', 'd', ' ' }, 
    new List<char> { 'g', 'r', 'e', 'e', 'n' }, 
    new List<char> { ' ', 'b', 'l', 'a', 'c', 'k' }, 
    new List<char> { 'b', 'l', 'u', 'e', ' ' }, 
    new List<char> { ' ', 'o', 'r', 'a', 'n', 'g', 'e' }, 
    new List<char> { 'b', 'r', 'o', 'w', 'n' } }));
```
