# mbcp26 -- Check if tuple list contains all k elements

## Text

Write a function to check if the given tuple list has all k elements.

## Code

```csharp
public bool CheckKElements(List<Tuple<int, int>> testList, int K) {
    bool res = true;
    foreach (var tup in testList) {
        foreach (var ele in tup) {
            if (ele != K) {
                res = false;
            }
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckKElements(new List<Tuple<int, int>> { Tuple.Create(4, 4), Tuple.Create(4, 4, 4), Tuple.Create(4, 4), Tuple.Create(4, 4, 4, 4), Tuple.Create(4, )}, 4) == true);
```

```csharp
Debug.Assert(CheckKElements(new (int, int)[]{(7, 7, 7), (7, 7)}, 7) == true);
```

```csharp
Debug.Assert(CheckKElements(new Tuple<int, int>[] { Tuple.Create(9, 9), Tuple.Create(9, 9, 9, 9) }, 7) == false);
```
