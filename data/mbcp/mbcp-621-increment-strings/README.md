# mbcp621 -- Increment numeric values in strings by k

## Text

Write a function to increment the numeric values in the given strings by k.

## Code

```csharp
public List<string> IncrementNumerics(List<string> testList, int K) 
{
    List<string> res = testList.Select(ele => int.TryParse(ele, out int num) ? (num + K).ToString() : ele).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(IncrementNumerics(new string[] { "MSM", "234", "is", "98", "123", "best", "4" }, 6).SequenceEqual(new string[] { "MSM", "240", "is", "104", "129", "best", "10" }));
```

```csharp
Debug.Assert(IncrementNumerics(new List<string> { "Dart", "356", "is", "88", "169", "Super", "6" }, 12).SequenceEqual(new List<string> { "Dart", "368", "is", "100", "181", "Super", "18" }));
```

```csharp
Debug.Assert(IncrementNumerics(new string[] { "Flutter", "451", "is", "44", "96", "Magnificent", "12" }, 33).SequenceEqual(new string[] { "Flutter", "484", "is", "77", "129", "Magnificent", "45" }));
```
