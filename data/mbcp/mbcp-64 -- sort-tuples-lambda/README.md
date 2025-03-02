# mbcp-64 -- Sort a list of tuples with a lambda function

## Text

Write a function to sort a list of tuples using lambda.

## Code

```csharp
public List<Tuple<string, int>> SubjectMarks(List<Tuple<string, int>> subjectmarks) 
{
    subjectmarks.Sort((x, y) => x.Item2.CompareTo(y.Item2));
    return subjectmarks;
}
```

## Test List

```csharp
Debug.Assert(SubjectMarks(new Tuple<string, int>[] { Tuple.Create("English", 88), Tuple.Create("Science", 90), Tuple.Create("Maths", 97), Tuple.Create("Social sciences", 82) }).SequenceEqual(new Tuple<string, int>[] { Tuple.Create("Social sciences", 82), Tuple.Create("English", 88), Tuple.Create("Science", 90), Tuple.Create("Maths", 97) }));
```

```csharp
Debug.Assert(SubjectMarks(new List<Tuple<string, int>> { Tuple.Create("Telugu", 49), Tuple.Create("Hindhi", 54), Tuple.Create("Social", 33) }).SequenceEqual(new List<Tuple<string, int>> { Tuple.Create("Social", 33), Tuple.Create("Telugu", 49), Tuple.Create("Hindhi", 54) }));
```

```csharp
Debug.Assert(SubjectMarks(new (string, int)[]{("Physics", 96), ("Chemistry", 97), ("Biology", 45)}) == new (string, int)[]{("Biology", 45), ("Physics", 96), ("Chemistry", 97)});
```
