# mbcp431 -- Check for common elements in two lists

## Text

Write a function that takes two lists and returns true if they have at least one common element.

## Code

```csharp
bool CommonElement(List<int> list1, List<int> list2) {
    bool result = false;
    foreach (int x in list1) {
        foreach (int y in list2) {
            if (x == y) {
                result = true;
                return result;
            }
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(CommonElement(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 6, 7, 8, 9 }) == true);
```

```csharp
Debug.Assert(CommonElement(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9 }) == null);
```

```csharp
Debug.Assert(CommonElement(new string[] { "a", "b", "c" }, new string[] { "d", "b", "e"}) == true);
```
