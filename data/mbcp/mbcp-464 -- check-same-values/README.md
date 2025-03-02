# mbcp-464 -- Check if all dictionary values are identical

## Text

Write a function to check if all values are same in a dictionary.

## Code

```csharp
public bool CheckValue(Dictionary<string, int> dict, int n)  
{  
    bool result = dict.Values.All(x => x == n);  
    return result;  
}
```

## Test List

```csharp
Debug.Assert(CheckValue(new Dictionary<string, int> { {"Cierra Vega", 12}, {"Alden Cantrell", 12}, {"Kierra Gentry", 12}, {"Pierre Cox", 12} }, 10) == false);
```

```csharp
Debug.Assert(CheckValue(new Dictionary<string, int>{{"Cierra Vega", 12}, {"Alden Cantrell", 12}, {"Kierra Gentry", 12}, {"Pierre Cox", 12}}, 12) == true);
```

```csharp
Debug.Assert(CheckValue(new Dictionary<string, int> { {"Cierra Vega", 12}, {"Alden Cantrell", 12}, {"Kierra Gentry", 12}, {"Pierre Cox", 12} }, 5) == false);
```
