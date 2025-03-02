# mbcp-650 -- Compare two arrays for equality in Python

## Text

Write a C# function to check whether the given two arrays are equal or not.

## Code

```csharp
bool AreEqual(int[] arr1, int[] arr2, int n, int m) {
    if (n != m) {
        return false;
    }
    Array.Sort(arr1);
    Array.Sort(arr2);
    for (int i = 0; i < n; i++) {
        if (arr1[i] != arr2[i]) {
            return false;
        }
    }
    return true;
}
```

## Test List

```csharp
Debug.Assert(AreEqual(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }, 3, 3) == true);
```

```csharp
Debug.Assert(AreEqual(new int[] { 1, 1, 1 }, new int[] { 2, 2, 2 }, 3, 3) == false);
```

```csharp
Debug.Assert(AreEqual(new int[] { 8, 9 }, new int[] { 4, 5, 6 }, 2, 3) == false);
```
