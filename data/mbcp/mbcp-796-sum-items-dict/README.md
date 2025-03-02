# mbcp796 -- Sum all values in a given dictionary

## Text

Write function to find the sum of all items in the given dictionary.

## Code

```csharp
public int ReturnSum(Dictionary<string, int> dict) {
    int sum = 0;
    foreach (var value in dict.Values) {
        sum += value;
    }
    return sum;
}
```

## Test List

```csharp
Debug.Assert(ReturnSum(new Dictionary<string, int> { { "a", 100 }, { "b", 200 }, { "c", 300 } }) == 600);
```

```csharp
Debug.Assert(ReturnSum(new Dictionary<string, int>{{"a", 25}, {"b", 18}, {"c", 45}}) == 88);
```

```csharp
Debug.Assert(ReturnSum(new Dictionary<string, int> { {"a", 36}, {"b", 39}, {"c", 49} }) == 124);
```
