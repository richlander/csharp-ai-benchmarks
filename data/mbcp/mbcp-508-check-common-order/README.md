# mbcp508 -- Check if common elements in lists preserve order

## Text

Write a function to check if the common elements between two given lists are in the same order or not.

## Code

```csharp
public bool SameOrder(List<int> l1, List<int> l2) {
    var commonElements = new HashSet<int>(l1).Intersect(l2).ToList();
    l1 = l1.Where(e => commonElements.Contains(e)).ToList();
    l2 = l2.Where(e => commonElements.Contains(e)).ToList();
    return l1.SequenceEqual(l2);
}
```

## Test List

```csharp
Debug.Assert(SameOrder(new string[] {"red", "green", "black", "orange"}, new string[] {"red", "pink", "green", "white", "black"}) == true);
```

```csharp
Debug.Assert(SameOrder(new string[] { "red", "pink", "green", "white", "black" }, new string[] { "white", "orange", "pink", "black" }) == false);
```

```csharp
Debug.Assert(SameOrder(new string[] { "red", "green", "black", "orange" }, new string[] { "red", "pink", "green", "white", "black" }) == true);
```
