# mbcp277 -- Filter a dictionary by its values using a function

## Text

Write a function to filter a dictionary based on values.

## Code

```csharp
public Dictionary<TKey, TValue> DictFilter<TKey, TValue>(Dictionary<TKey, TValue> dict, TValue n) where TValue : IComparable
{
    var result = dict.Where(kvp => kvp.Value.CompareTo(n) >= 0).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    return result;
}
```

## Test List

```csharp
Debug.Assert(DictFilter(new Dictionary<string, int>{{"Cierra Vega", 175}, {"Alden Cantrell", 180}, {"Kierra Gentry", 165}, {"Pierre Cox", 190}}, 170).SequenceEqual(new Dictionary<string, int>{{"Cierra Vega", 175}, {"Alden Cantrell", 180}, {"Pierre Cox", 190}}));
```

```csharp
Debug.Assert(DictFilter(new Dictionary<string, int> { { "Cierra Vega", 175 }, { "Alden Cantrell", 180 }, { "Kierra Gentry", 165 }, { "Pierre Cox", 190 } }, 180).SequenceEqual(new Dictionary<string, int> { { "Alden Cantrell", 180 }, { "Pierre Cox", 190 } }));
```

```csharp
Debug.Assert(DictFilter(new Dictionary<string, int> { {"Cierra Vega", 175}, {"Alden Cantrell", 180}, {"Kierra Gentry", 165}, {"Pierre Cox", 190} }, 190).SequenceEqual(new Dictionary<string, int> { {"Pierre Cox", 190} }));
```
