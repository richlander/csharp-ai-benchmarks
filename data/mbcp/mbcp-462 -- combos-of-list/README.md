# mbcp-462 -- Find all combinations of list elements

## Text

Write a function to find all possible combinations of the elements of a given list.

## Code

```csharp
public List<List<T>> CombinationsList<T>(List<T> list1)
{
    if (list1.Count == 0)
    {
        return new List<List<T>> { new List<T>() };
    }
    
    var result = new List<List<T>>();
    foreach (var el in CombinationsList(list1.GetRange(1, list1.Count - 1)))
    {
        result.Add(el);
        var newCombination = new List<T>(el) { list1[0] };
        result.Add(newCombination);
    }
    
    return result;
}
```

## Test List

```csharp
Debug.Assert(CombinationsList(new List<string> { "orange", "red", "green", "blue" }).SequenceEqual(new List<List<string>> {
    new List<string>(),
    new List<string> { "orange" },
    new List<string> { "red" },
    new List<string> { "red", "orange" },
    new List<string> { "green" },
    new List<string> { "green", "orange" },
    new List<string> { "green", "red" },
    new List<string> { "green", "red", "orange" },
    new List<string> { "blue" },
    new List<string> { "blue", "orange" },
    new List<string> { "blue", "red" },
    new List<string> { "blue", "red", "orange" },
    new List<string> { "blue", "green" },
    new List<string> { "blue", "green", "orange" },
    new List<string> { "blue", "green", "red" },
    new List<string> { "blue", "green", "red", "orange" }
}));
```

```csharp
Debug.Assert(CombinationsList(new List<string> { "red", "green", "blue", "white", "black", "orange" }).SequenceEqual(new List<List<string>> {
    new List<string>(),
    new List<string> { "red" },
    new List<string> { "green" },
    new List<string> { "green", "red" },
    new List<string> { "blue" },
    new List<string> { "blue", "red" },
    new List<string> { "blue", "green" },
    new List<string> { "blue", "green", "red" },
    new List<string> { "white" },
    new List<string> { "white", "red" },
    new List<string> { "white", "green" },
    new List<string> { "white", "green", "red" },
    new List<string> { "white", "blue" },
    new List<string> { "white", "blue", "red" },
    new List<string> { "white", "blue", "green" },
    new List<string> { "white", "blue", "green", "red" },
    new List<string> { "black" },
    new List<string> { "black", "red" },
    new List<string> { "black", "green" },
    new List<string> { "black", "green", "red" },
    new List<string> { "black", "blue" },
    new List<string> { "black", "blue", "red" },
    new List<string> { "black", "blue", "green" },
    new List<string> { "black", "blue", "green", "red" },
    new List<string> { "black", "white" },
    new List<string> { "black", "white", "red" },
    new List<string> { "black", "white", "green" },
    new List<string> { "black", "white", "green", "red" },
    new List<string> { "black", "white", "blue" },
    new List<string> { "black", "white", "blue", "red" },
    new List<string> { "black", "white", "blue", "green" },
    new List<string> { "black", "white", "blue", "green", "red" },
    new List<string> { "orange" },
    new List<string> { "orange", "red" },
    new List<string> { "orange", "green" },
    new List<string> { "orange", "green", "red" },
    new List<string> { "orange", "blue" },
    new List<string> { "orange", "blue", "red" },
    new List<string> { "orange", "blue", "green" },
    new List<string> { "orange", "blue", "green", "red" },
    new List<string> { "orange", "white" },
    new List<string> { "orange", "white", "red" },
    new List<string> { "orange", "white", "green" },
    new List<string> { "orange", "white", "green", "red" },
    new List<string> { "orange", "white", "blue" },
    new List<string> { "orange", "white", "blue", "red" },
    new List<string> { "orange", "white", "blue", "green" },
    new List<string> { "orange", "white", "blue", "green", "red" },
    new List<string> { "orange", "black" },
    new List<string> { "orange", "black", "red" },
    new List<string> { "orange", "black", "green" },
    new List<string> { "orange", "black", "green", "red" },
    new List<string> { "orange", "black", "blue" },
    new List<string> { "orange", "black", "blue", "red" },
    new List<string> { "orange", "black", "blue", "green" },
    new List<string> { "orange", "black", "blue", "green", "red" },
    new List<string> { "orange", "black", "white" },
    new List<string> { "orange", "black", "white", "red" },
    new List<string> { "orange", "black", "white", "green" },
    new List<string> { "orange", "black", "white", "green", "red" },
    new List<string> { "orange", "black", "white", "blue" },
    new List<string> { "orange", "black", "white", "blue", "red" },
    new List<string> { "orange", "black", "white", "blue", "green" },
    new List<string> { "orange", "black", "white", "blue", "green", "red" }
}));
```

```csharp
Debug.Assert(CombinationsList(new List<string> { "red", "green", "black", "orange" }).SequenceEqual(new List<List<string>> 
{ 
    new List<string>(), 
    new List<string> { "red" }, 
    new List<string> { "green" }, 
    new List<string> { "green", "red" }, 
    new List<string> { "black" }, 
    new List<string> { "black", "red" }, 
    new List<string> { "black", "green" }, 
    new List<string> { "black", "green", "red" }, 
    new List<string> { "orange" }, 
    new List<string> { "orange", "red" }, 
    new List<string> { "orange", "green" }, 
    new List<string> { "orange", "green", "red" }, 
    new List<string> { "orange", "black" }, 
    new List<string> { "orange", "black", "red" }, 
    new List<string> { "orange", "black", "green" }, 
    new List<string> { "orange", "black", "green", "red" } 
}));
```
