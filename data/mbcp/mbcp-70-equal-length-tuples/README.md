# mbcp70 -- Check if all tuples have equal length

## Text

Write a function to find whether all the given tuples have equal length or not.

## Code

```csharp
public int FindEqualTuple(List<Tuple> input, int k) {
    int flag = 1;
    foreach (var tuple in input) {
        if (tuple.Length != k) {
            flag = 0;
            break;
        }
    }
    return flag;
}

public string GetEqual(List<Tuple> input, int k) {
    if (FindEqualTuple(input, k) == 1) {
        return "All tuples have same length";
    } else {
        return "All tuples do not have same length";
    }
}
```

## Test List

```csharp
Debug.Assert(GetEqual(new List<(int, int, int)> { (11, 22, 33), (44, 55, 66) }, 3) == "All tuples have same length");
```

```csharp
Debug.Assert(GetEqual(new List<Tuple<int, int, int>> { Tuple.Create(1, 2, 3), Tuple.Create(4, 5, 6, 7) }, 3) == "All tuples do not have same length");
```

```csharp
Debug.Assert(GetEqual(new List<Tuple<int, int>> { Tuple.Create(1, 2), Tuple.Create(3, 4) }, 2) == "All tuples have same length");
```
