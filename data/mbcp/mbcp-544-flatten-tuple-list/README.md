# mbcp544 -- Flatten tuple list into a single string

## Text

Write a function to flatten the tuple list to a string.

## Code

```csharp
public string FlattenTuple(List<Tuple<string>> testList)  
{  
    string res = string.Join(" ", testList.SelectMany(tup => tup));  
    return res;  
}
```

## Test List

```csharp
Debug.Assert(FlattenTuple(new Tuple<string, string, string>[] { Tuple.Create("1", "4", "6"), Tuple.Create("5", "8"), Tuple.Create("2", "9"), Tuple.Create("1", "10") }) == "1 4 6 5 8 2 9 1 10");
```

```csharp
Debug.Assert(FlattenTuple(new Tuple<string, string>[] { Tuple.Create("2", "3", "4"), Tuple.Create("6", "9"), Tuple.Create("3", "2"), Tuple.Create("2", "11") }) == "2 3 4 6 9 3 2 2 11");
```

```csharp
Debug.Assert(FlattenTuple(new Tuple<string, string>[] { Tuple.Create("14", "21", "9"), Tuple.Create("24", "19"), Tuple.Create("12", "29"), Tuple.Create("23", "17") }) == "14 21 9 24 19 12 29 23 17");
```
