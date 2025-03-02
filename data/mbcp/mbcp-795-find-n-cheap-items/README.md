# mbcp795 -- Find n cheapest items using a heap queue

## Text

Write a function to find the n - cheap price items from a given dataset using heap queue algorithm.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public decimal Price { get; set; }
}

public class ItemHelper
{
    public List<Item> CheapItems(List<Item> items, int n)
    {
        return items.OrderBy(item => item.Price).Take(n).ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(CheapItems(new List<Dictionary<string, object>> { new Dictionary<string, object> { { "name", "Item-1" }, { "price", 101.1 } }, new Dictionary<string, object> { { "name", "Item-2" }, { "price", 555.22 } } }, 1).SequenceEqual(new List<Dictionary<string, object>> { new Dictionary<string, object> { { "name", "Item-1" }, { "price", 101.1 } } }));
```

```csharp
Debug.Assert(CheapItems(new List<Dictionary<string, object>> { new Dictionary<string, object> { { "name", "Item-1" }, { "price", 101.1 } }, new Dictionary<string, object> { { "name", "Item-2" }, { "price", 555.22 } } }, 2).SequenceEqual(new List<Dictionary<string, object>> { new Dictionary<string, object> { { "name", "Item-1" }, { "price", 101.1 } }, new Dictionary<string, object> { { "name", "Item-2" }, { "price", 555.22 } } }));
```

```csharp
Debug.Assert(CheapItems(new List<Dictionary<string, object>> { 
    new Dictionary<string, object> { { "name", "Item-1" }, { "price", 101.1 } }, 
    new Dictionary<string, object> { { "name", "Item-2" }, { "price", 555.22 } }, 
    new Dictionary<string, object> { { "name", "Item-3" }, { "price", 45.09 } }, 
    new Dictionary<string, object> { { "name", "Item-4" }, { "price", 22.75 } } 
}, 1).SequenceEqual(new List<Dictionary<string, object>> { 
    new Dictionary<string, object> { { "name", "Item-4" }, { "price", 22.75 } } }));
```
