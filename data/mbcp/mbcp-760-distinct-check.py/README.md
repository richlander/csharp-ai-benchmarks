# mbcp760 -- Check if an array has one distinct element

## Text

Write a C# function to check whether an array contains only one distinct element or not.

## Code

```csharp
public string UniqueElement(int[] arr, int n) {
    HashSet<int> s = new HashSet<int>(arr);
    if (s.Count == 1) {
        return "YES";
    } else {
        return "NO";
    }
}
```

## Test List

```csharp
Debug.Assert(UniqueElement(new int[] { 1, 1, 1 }, 3) == "YES");
```

```csharp
Debug.Assert(UniqueElement(new int[] { 1, 2, 1, 2 }, 4) == "NO");
```

```csharp
Debug.Assert(UniqueElement(new int[] { 1, 2, 3, 4, 5 }, 5) == "NO");
```
