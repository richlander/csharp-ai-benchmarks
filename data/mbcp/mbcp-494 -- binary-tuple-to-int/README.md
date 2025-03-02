# mbcp-494 -- Convert a binary tuple to its integer value

## Text

Write a function to convert the given binary tuple to integer.

## Code

```csharp
public string BinaryToInteger(Tuple<int>[] testTup) {
    string res = Convert.ToInt32(string.Join("", testTup.Select(ele => ele.ToString())), 2).ToString();
    return res;
}
```

## Test List

```csharp
Debug.Assert(BinaryToInteger(new int[] { 1, 1, 0, 1, 0, 0, 1 }) == "105");
```

```csharp
Debug.Assert(BinaryToInteger(new int[] { 0, 1, 1, 0, 0, 1, 0, 1 }) == "101");
```

```csharp
Debug.Assert(BinaryToInteger(new int[] { 1, 1, 0, 1, 0, 1 }) == "53");
```
