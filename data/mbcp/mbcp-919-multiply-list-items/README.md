# mbcp919 -- Multiply all elements in a list using Python

## Text

Write a C# function to multiply all items in the list.

## Code

```csharp
public int MultiplyList(List<int> items) {
    int tot = 1;
    foreach (int x in items) {
        tot *= x;
    }
    return tot;
}
```

## Test List

```csharp
Debug.Assert(MultiplyList(new List<int> { 1, -2, 3 }) == -6);
```

```csharp
Debug.Assert(MultiplyList(new int[] { 1, 2, 3, 4 }) == 24);
```

```csharp
Debug.Assert(MultiplyList(new List<int> { 3, 1, 2, 3 }) == 18);
```
