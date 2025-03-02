# mbcp-253 -- Count integers in a given list using Python

## Text

Write a C# function to count integers from a given list.

## Code

```csharp
public int CountInteger(List<object> list1) {
    int ctr = 0;
    foreach (var i in list1) {
        if (i is int) {
            ctr++;
        }
    }
    return ctr;
}
```

## Test List

```csharp
Debug.Assert(CountInteger(new object[] { 1, 2, "abc", 1.2 }) == 2);
```

```csharp
Debug.Assert(CountInteger(new int[] { 1, 2, 3 }) == 3);
```

```csharp
Debug.Assert(CountInteger(new double[] { 1, 1.2, 4, 5.1 }) == 2);
```
