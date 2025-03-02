# mbcp-769 -- Calculate the difference between two lists in Python

## Text

Write a C# function to get the difference between two lists.

## Code

```csharp
public List<int> Diff(List<int> li1, List<int> li2) 
{
    return new List<int>(new HashSet<int>(li1).Except(li2).Union(new HashSet<int>(li2).Except(li1)));
}
```

## Test List

```csharp
Debug.Assert(Diff(new int[] { 10, 15, 20, 25, 30, 35, 40 }, new int[] { 25, 40, 35 }).SequenceEqual(new int[] { 10, 20, 30, 15 }));
```

```csharp
Debug.Assert(Diff(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 1 }).SequenceEqual(new int[] { 2, 3, 4, 5, 6, 7 }));
```

```csharp
Debug.Assert(Diff(new List<int> { 1, 2, 3 }, new List<int> { 6, 7, 1 }).SequenceEqual(new List<int> { 2, 3, 6, 7 }));
```
