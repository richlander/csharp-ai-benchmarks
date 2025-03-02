# mbcp439 -- Convert a list of integers into a single integer

## Text

Write a function to convert a list of multiple integers into a single integer.

## Code

```csharp
public int MultipleToSingle(List<int> L)
{
    string x = string.Join("", L.Select(i => i.ToString()));
    return int.Parse(x);
}
```

## Test List

```csharp
Debug.Assert(MultipleToSingle(new int[] { 11, 33, 50 }) == 113350);
```

```csharp
Debug.Assert(MultipleToSingle(new int[] { -1, 2, 3, 4, 5, 6 }) == -123456);
```

```csharp
Debug.Assert(MultipleToSingle(new int[] { 10, 15, 20, 25 }) == 10152025);
```
