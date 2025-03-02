# mbcp281 -- Check if list elements are unique in Python

## Text

Write a C# function to check if the elements of a given list are unique or not.

## Code

```csharp
public static bool AllUnique(List<int> testList) {
    if (testList.Count > new HashSet<int>(testList).Count) {
        return false;
    }
    return true;
}
```

## Test List

```csharp
Debug.Assert(AllUnique(new int[] { 1, 2, 3 }) == true);
```

```csharp
Debug.Assert(AllUnique(new List<int> { 1, 2, 1, 2 }) == false);
```

```csharp
Debug.Assert(AllUnique(new int[] { 1, 2, 3, 4, 5 }) == true);
```
