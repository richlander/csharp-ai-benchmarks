# mbcp-378 -- Shift last element of a list to the front

## Text

Write a C# function to shift last element to first position in the given list.

## Code

```csharp
public List<T> MoveFirst<T>(List<T> testList) {
    testList = new List<T> { testList.Last() };
    testList.AddRange(testList.Take(testList.Count - 1));
    return testList;
}
```

## Test List

```csharp
Debug.Assert(MoveFirst(new int[] { 1, 2, 3, 4 }).SequenceEqual(new int[] { 4, 1, 2, 3 }));
```

```csharp
Debug.Assert(MoveFirst(new int[] { 0, 1, 2, 3 }).SequenceEqual(new int[] { 3, 0, 1, 2 }));

int[] MoveFirst(int[] arr) 
{
    if (arr.Length == 0) return arr;
    int[] result = new int[arr.Length];
    result[0] = arr[arr.Length - 1];
    Array.Copy(arr, 0, result, 1, arr.Length - 1);
    return result;
}
```

```csharp
Debug.Assert(MoveFirst(new int[] { 9, 8, 7, 1 }).SequenceEqual(new int[] { 1, 9, 8, 7 }));
```
