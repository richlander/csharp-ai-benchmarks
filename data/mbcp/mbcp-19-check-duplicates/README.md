# mbcp19 -- Check for duplicates in an integer array

## Text

Write a function to find whether a given array of integers contains any duplicate element.

## Code

```csharp
public bool TestDuplicate(int[] arraynums) {
    HashSet<int> numsSet = new HashSet<int>(arraynums);
    return arraynums.Length != numsSet.Count;
}
```

## Test List

```csharp
Debug.Assert(TestDuplicate(new int[] { 1, 2, 3, 4, 5 }) == false);
```

```csharp
Debug.Assert(TestDuplicate(new int[] { 1, 2, 3, 4, 4 }) == true);
```

```csharp
Debug.Assert(TestDuplicate(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5 }) == true);
```
