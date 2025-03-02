# mbcp297 -- Flatten a nested list into a single list

## Text

Write a function to flatten a given nested list structure.

## Code

```csharp
public List<object> FlattenList(List<object> list1) {
    List<object> resultList = new List<object>();
    if (list1.Count == 0) return resultList;
    Stack<List<object>> stack = new Stack<List<object>>();
    stack.Push(new List<object>(list1));
    while (stack.Count > 0) {
        List<object> cNum = stack.Pop();
        object next = cNum[cNum.Count - 1];
        cNum.RemoveAt(cNum.Count - 1);
        if (cNum.Count > 0) stack.Push(cNum);
        if (next is List<object> nextList) {
            if (nextList.Count > 0) stack.Push(new List<object>(nextList));
        } else {
            resultList.Add(next);
        }
    }
    resultList.Reverse();
    return resultList;
}
```

## Test List

```csharp
Debug.Assert(FlattenList(new object[] { 0, 10, new object[] { 20, 30 }, 40, 50, new object[] { 60, 70, 80 }, new object[] { 90, 100, 110, 120 } }).SequenceEqual(new List<int> { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 }));
```

```csharp
Debug.Assert(FlattenList(new List<List<int>> { new List<int> { 10, 20 }, new List<int> { 40 }, new List<int> { 30, 56, 25 }, new List<int> { 10, 20 }, new List<int> { 33 }, new List<int> { 40 } }).SequenceEqual(new List<int> { 10, 20, 40, 30, 56, 25, 10, 20, 33, 40 }));
```

```csharp
Debug.Assert(FlattenList(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 10, 11, 12 }, new List<int> { 7, 8, 9 } }) .SequenceEqual(new List<int> { 1, 2, 3, 4, 5, 6, 10, 11, 12, 7, 8, 9 }));
```
