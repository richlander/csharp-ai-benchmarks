# mbcp-533 -- Remove specific data types from a tuple

## Text

Write a function to remove particular data type elements from the given tuple.

## Code

```csharp
public List<object> RemoveDatatype(Tuple<object> testTuple, Type dataType) {
    List<object> res = new List<object>();
    foreach (var ele in testTuple) {
        if (!dataType.IsInstanceOfType(ele)) {
            res.Add(ele);
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(RemoveDatatype(new object[] { 4, 5, 4, 7.7, 1.2 }, typeof(int)).SequenceEqual(new List<double> { 7.7, 1.2 }));
```

```csharp
Debug.Assert(RemoveDatatype(new Tuple<object, object, object, string>(7, 8, 9, "SR"), typeof(string)).Equals(new List<int> { 7, 8, 9 }));
```

```csharp
Debug.Assert(RemoveDatatype(new Tuple<int, double, int, double>(7, 1.1, 2, 2.2), typeof(float)).SequenceEqual(new List<int> { 7, 2 }));
```
