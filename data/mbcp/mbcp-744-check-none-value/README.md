# mbcp744 -- Check for None values in a given tuple

## Text

Write a function to check if the given tuple has any none value or not.

## Code

```csharp
bool CheckNone(Tuple<object>[] testTup) {
    bool res = testTup.Any(ele => ele == null);
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckNone(new Tuple<int, int, int, int, int>(10, 4, 5, 6, null)) == true);
```

```csharp
Debug.Assert(CheckNone(new int[] { 7, 8, 9, 11, 14 }) == false);
```

```csharp
Debug.Assert(CheckNone(new object[] { 1, 2, 3, 4, null }) == true);
```
