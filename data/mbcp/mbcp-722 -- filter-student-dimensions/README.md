# mbcp-722 -- Filter students' height and width from a dictionary

## Text

Write a function to filter the height and width of students which are stored in a dictionary.

## Code

```csharp
public Dictionary<string, (int, int)> FilterData(Dictionary<string, (int, int)> students, int h, int w)
{
    var result = students.Where(kvp => kvp.Value.Item1 >= h && kvp.Value.Item2 >= w)
                         .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    return result;
}
```

## Test List

```csharp
Debug.Assert(FilterData(new Dictionary<string, (double, int)> { { "Cierra Vega", (6.2, 70) }, { "Alden Cantrell", (5.9, 65) }, { "Kierra Gentry", (6.0, 68) }, { "Pierre Cox", (5.8, 66) } }, 6.0, 70).SequenceEqual(new Dictionary<string, (double, int)> { { "Cierra Vega", (6.2, 70) } }));
```

```csharp
Debug.Assert(FilterData(new Dictionary<string, (double, int)> { { "Cierra Vega", (6.2, 70) }, { "Alden Cantrell", (5.9, 65) }, { "Kierra Gentry", (6.0, 68) }, { "Pierre Cox", (5.8, 66) } }, 5.9, 67).SequenceEqual(new Dictionary<string, (double, int)> { { "Cierra Vega", (6.2, 70) }, { "Kierra Gentry", (6.0, 68) } }));
```

```csharp
Debug.Assert(FilterData(new Dictionary<string, (double, int)>{{"Cierra Vega", (6.2, 70)}, {"Alden Cantrell", (5.9, 65)}, {"Kierra Gentry", (6.0, 68)}, {"Pierre Cox", (5.8, 66)}}, 5.7, 64).SequenceEqual(new Dictionary<string, (double, int)>{{"Cierra Vega", (6.2, 70)}, {"Alden Cantrell", (5.9, 65)}, {"Kierra Gentry", (6.0, 68)}, {"Pierre Cox", (5.8, 66)}}));
```
