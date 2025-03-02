# mbcp280 -- Sequential search for an element in an array

## Text

Write a function to search an element in the given array by using sequential search.

## Code

```csharp
public (bool, int) SequentialSearch(List<int> dlist, int item) {
    int pos = 0;
    bool found = false;
    while (pos < dlist.Count && !found) {
        if (dlist[pos] == item) {
            found = true;
        } else {
            pos++;
        }
    }
    return (found, pos);
}
```

## Test List

```csharp
Debug.Assert(SequentialSearch(new int[] { 11, 23, 58, 31, 56, 77, 43, 12, 65, 19 }, 31).Equals((true, 3)));
```

```csharp
Debug.Assert(SequentialSearch(new int[] { 12, 32, 45, 62, 35, 47, 44, 61 }, 61).Equals((true, 7)));
```

```csharp
Debug.Assert(SequentialSearch(new int[] { 9, 10, 17, 19, 22, 39, 48, 56 }, 48).Equals((true, 6)));
```
