# mbcp698 -- Sort dictionary items by tuple key products

## Text

Write a function to sort dictionary items by tuple product of keys for the given dictionary with tuple keys.

## Code

```csharp
public Dictionary<TKey, TValue> SortDictItem<TKey, TValue>(Dictionary<TKey, TValue> testDict) 
 {
     var res = testDict.OrderBy(keyValue => Convert.ToDouble(keyValue.Key.ToString()[1].ToString()) * Convert.ToDouble(keyValue.Key.ToString()[0].ToString()))
                        .ToDictionary(keyValue => keyValue.Key, keyValue => keyValue.Value);
     return res;
 }
```

## Test List

```csharp
Debug.Assert(SortDictItem(new Dictionary<(int, int), int> { {(5, 6), 3}, {(2, 3), 9}, {(8, 4), 10}, {(6, 4), 12} }) == new Dictionary<(int, int), int> { {(2, 3), 9}, {(6, 4), 12}, {(5, 6), 3}, {(8, 4), 10} });
```

```csharp
Debug.Assert(SortDictItem(new Dictionary<(int, int), int> { {(6, 7), 4}, {(3, 4), 10}, {(9, 5), 11}, {(7, 5), 13} }).SequenceEqual(new Dictionary<(int, int), int> { {(3, 4), 10}, {(7, 5), 13}, {(6, 7), 4}, {(9, 5), 11} }));
```

```csharp
Debug.Assert(SortDictItem(new Dictionary<(int, int), int> { { (7, 8), 5 }, { (4, 5), 11 }, { (10, 6), 12 }, { (8, 6), 14 } }) == new Dictionary<(int, int), int> { { (4, 5), 11 }, { (8, 6), 14 }, { (7, 8), 5 }, { (10, 6), 12 } });
```
