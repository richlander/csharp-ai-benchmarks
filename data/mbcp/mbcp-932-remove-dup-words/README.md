# mbcp932 -- Remove duplicates from a list of words

## Text

Write a function to remove duplicate words from a given list of strings.

## Code

```csharp
public List<T> RemoveDuplicList<T>(List<T> l)
{
    List<T> temp = new List<T>();
    foreach (T x in l)
    {
        if (!temp.Contains(x))
        {
            temp.Add(x);
        }
    }
    return temp;
}
```

## Test List

```csharp
Debug.Assert(RemoveDuplicList(new List<string> { "Python", "Exercises", "Practice", "Solution", "Exercises" }).SequenceEqual(new List<string> { "Python", "Exercises", "Practice", "Solution" }));
```

```csharp
Debug.Assert(RemoveDuplicList(new List<string> { "Python", "Exercises", "Practice", "Solution", "Exercises", "Java" }).SequenceEqual(new List<string> { "Python", "Exercises", "Practice", "Solution", "Java" }));
```

```csharp
Debug.Assert(RemoveDuplicList(new List<string> { "Python", "Exercises", "Practice", "Solution", "Exercises", "C++", "C", "C++" }).SequenceEqual(new List<string> { "Python", "Exercises", "Practice", "Solution", "C++", "C" }));
```
