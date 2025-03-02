# mbcp-792 -- Count lists within a list in Python function

## Text

Write a C# function to count the number of lists in a given number of lists.

## Code

```csharp
public int CountList(List<object> inputList) 
{ 
    return inputList.Count; 
}
```

## Test List

```csharp
Debug.Assert(CountList(new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }) == 4);
```

```csharp
Debug.Assert(CountList(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 4, 5 } }) == 3);
```

```csharp
Debug.Assert(CountList(new List<List<int>> { new List<int> { 1, 0 }, new List<int> { 2, 0 } }) == 2);
```
