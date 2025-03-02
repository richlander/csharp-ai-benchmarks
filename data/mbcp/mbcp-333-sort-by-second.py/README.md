# mbcp333 -- Sort list by second element of each sublist

## Text

Write a C# function to sort a list according to the second element in sublist.

## Code

```csharp
public List<List<T>> Sort<T>(List<List<T>> subLi) 
{
    subLi.Sort((x, y) => Comparer<T>.Default.Compare(x[1], y[1]));
    return subLi;
}
```

## Test List

```csharp
Debug.Assert(Sort(new object[][] { new object[] { "a", 10 }, new object[] { "b", 5 }, new object[] { "c", 20 }, new object[] { "d", 15 } }) == new object[][] { new object[] { "b", 5 }, new object[] { "a", 10 }, new object[] { "d", 15 }, new object[] { "c", 20 } });
```

```csharp
Debug.Assert(Sort(new object[][] { new object[] { "452", 10 }, new object[] { "256", 5 }, new object[] { "100", 20 }, new object[] { "135", 15 } }) == new object[][] { new object[] { "256", 5 }, new object[] { "452", 10 }, new object[] { "135", 15 }, new object[] { "100", 20 } });
```

```csharp
Debug.Assert(Sort(new object[,] { { "rishi", 10 }, { "akhil", 5 }, { "ramya", 20 }, { "gaur", 15 } }) == new object[,] { { "akhil", 5 }, { "rishi", 10 }, { "gaur", 15 }, { "ramya", 20 } });
```
