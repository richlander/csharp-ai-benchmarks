# mbcp858 -- Count lists in a list and return the square

## Text

Write a function to count number of lists in a given list of lists and square the count.

## Code

```csharp
public int CountList(List<object> inputList) 
{ 
    return (inputList.Count) * (inputList.Count); 
}
```

## Test List

```csharp
Debug.Assert(CountList(new List<List<int>> { new List<int> { 0 }, new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }) == 25);
```

```csharp
Debug.Assert(CountList(new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }) == 16);
```

```csharp
Debug.Assert(CountList(new object[][] { new object[] { 2, 4 }, new object[][] { new object[][] { 6, 8 }, new object[] { 4, 5, 8 } }, new object[] { 10, 12, 14 } }) == 9);
```
