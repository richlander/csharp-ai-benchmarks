# mbcp673 -- Convert a list of integers into a single integer

## Text

Write a C# function to convert a list of multiple integers into a single integer.

## Code

```csharp
public int Convert(List<int> list) 
{ 
    var s = list.Select(i => i.ToString()).ToList(); 
    var res = int.Parse(string.Join("", s)); 
    return res; 
}
```

## Test List

```csharp
Debug.Assert(Convert(new int[] { 1, 2, 3 }) == 123);
```

```csharp
Debug.Assert(Convert(new int[] { 4, 5, 6 }) == 456);
```

```csharp
Debug.Assert(Convert(new int[] { 7, 8, 9 }) == 789);
```
