# mbcp-87 -- Merge three dictionaries into one expression

## Text

Write a function to merge three dictionaries into a single expression.

## Code

```csharp
public static Dictionary<string, object> MergeDictionariesThree(Dictionary<string, object> dict1, Dictionary<string, object> dict2, Dictionary<string, object> dict3) {
    var mergedDict = new Dictionary<string, object>(dict1);
    foreach (var kvp in dict2) {
        mergedDict[kvp.Key] = kvp.Value;
    }
    foreach (var kvp in dict3) {
        mergedDict[kvp.Key] = kvp.Value;
    }
    return mergedDict;
}
```

## Test List

```csharp
Debug.Assert(MergeDictionariesThree(new Dictionary<string, string> { { "R", "Red" }, { "B", "Black" }, { "P", "Pink" } }, new Dictionary<string, string> { { "G", "Green" }, { "W", "White" } }, new Dictionary<string, string> { { "O", "Orange" }, { "W", "White" }, { "B", "Black" } }) == new Dictionary<string, string> { { "B", "Black" }, { "R", "Red" }, { "P", "Pink" }, { "G", "Green" }, { "W", "White" }, { "O", "Orange" } });
```

```csharp
Debug.Assert(MergeDictionariesThree(new Dictionary<string, string> { { "R", "Red" }, { "B", "Black" }, { "P", "Pink" } }, 
                                     new Dictionary<string, string> { { "G", "Green" }, { "W", "White" } }, 
                                     new Dictionary<string, string> { { "L", "lavender" }, { "B", "Blue" } }) 
                                     .SequenceEqual(new Dictionary<string, string> { { "W", "White" }, { "P", "Pink" }, { "B", "Black" }, { "R", "Red" }, { "G", "Green" }, { "L", "lavender" } }));
```

```csharp
Debug.Assert(MergeDictionariesThree(new Dictionary<string, string> { {"R", "Red"}, {"B", "Black"}, {"P", "Pink"} }, new Dictionary<string, string> { {"L", "lavender"}, {"B", "Blue"} }, new Dictionary<string, string> { {"G", "Green"}, {"W", "White"} }).SequenceEqual(new Dictionary<string, string> { {"B", "Black"}, {"P", "Pink"}, {"R", "Red"}, {"G", "Green"}, {"L", "lavender"}, {"W", "White"} }));
```
