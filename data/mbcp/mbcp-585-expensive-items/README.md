# mbcp585 -- Find n most expensive items using heap queue

## Text

Write a function to find the n - expensive price items from a given dataset using heap queue algorithm.

## Code

```csharp
public List<Dictionary<string, object>> ExpensiveItems(List<Dictionary<string, object>> items, int n) {
    return items.OrderByDescending(item => (decimal)item["price"]).Take(n).ToList();
}
```

## Test List

```csharp
Debug.Assert(ExpensiveItems(new List<Dictionary<string, object>> { new Dictionary<string, object> { { "name", "Item-1" }, { "price", 101.1 } }, new Dictionary<string, object> { { "name", "Item-2" }, { "price", 555.22 } } }, 1).SequenceEqual(new List<Dictionary<string, object>> { new Dictionary<string, object> { { "name", "Item-2" }, { "price", 555.22 } } }));
```

```csharp
Debug.Assert(ExpensiveItems(new List<Dictionary<string, object>>{ new Dictionary<string, object>{{"name", "Item-1"}, {"price", 101.1}}, new Dictionary<string, object>{{"name", "Item-2"}, {"price", 555.22}}, new Dictionary<string, object>{{"name", "Item-3"}, {"price", 45.09}}}, 2).SequenceEqual(new List<Dictionary<string, object>>{ new Dictionary<string, object>{{"name", "Item-2"}, {"price", 555.22}}, new Dictionary<string, object>{{"name", "Item-1"}, {"price", 101.1}}}));
```

```csharp
Debug.Assert(ExpensiveItems(new List<Dictionary<string, object>> { new Dictionary<string, object> { { "name", "Item-1" }, { "price", 101.1 } }, new Dictionary<string, object> { { "name", "Item-2" }, { "price", 555.22 } }, new Dictionary<string, object> { { "name", "Item-3" }, { "price", 45.09 } }, new Dictionary<string, object> { { "name", "Item-4" }, { "price", 22.75 } } }, 1).SequenceEqual(new List<Dictionary<string, object>> { new Dictionary<string, object> { { "name", "Item-2" }, { "price", 555.22 } } }));
```
