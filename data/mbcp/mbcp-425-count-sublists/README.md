# mbcp425 -- Count sublists with a specified element present

## Text

Write a function to count the number of sublists containing a particular element.

## Code

```csharp
public int CountElementInList(List<string> list1, string x) 
{ 
    int ctr = 0; 
    for (int i = 0; i < list1.Count; i++) 
    { 
        if (list1[i].Contains(x)) 
        { 
            ctr++; 
        } 
    } 
    return ctr; 
}
```

## Test List

```csharp
Debug.Assert(CountElementInList(new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 1, 11 }, new List<int> { 1, 15, 7 } }, 1) == 3);
```

```csharp
Debug.Assert(CountElementInList(new List<List<string>> { new List<string> { "A", "B" }, new List<string> { "A", "C" }, new List<string> { "A", "D", "E" }, new List<string> { "B", "C", "D" } }, "A") == 3);
```

```csharp
Debug.Assert(CountElementInList(new List<List<string>> { new List<string> { "A", "B" }, new List<string> { "A", "C" }, new List<string> { "A", "D", "E" }, new List<string> { "B", "C", "D" } }, "E") == 1);
```
