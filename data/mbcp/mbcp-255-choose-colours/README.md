# mbcp255 -- Generate colour combinations with repetitions allowed

## Text

Write a function to choose specified number of colours from three different colours and generate all the combinations with repetitions.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class CombinationGenerator
{
    public static List<List<T>> CombinationsColors<T>(List<T> l, int n)
    {
        return combinationsWithReplacement(l, n);
    }

    private static List<List<T>> combinationsWithReplacement<T>(List<T> l, int n)
    {
        List<List<T>> result = new List<List<T>>();
        CombinationsWithReplacementHelper(l, n, new List<T>(), result);
        return result;
    }

    private static void CombinationsWithReplacementHelper<T>(List<T> l, int n, List<T> current, List<List<T>> result)
    {
        if (current.Count == n)
        {
            result.Add(new List<T>(current));
            return;
        }

        for (int i = 0; i < l.Count; i++)
        {
            current.Add(l[i]);
            CombinationsWithReplacementHelper(l, n, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
```

## Test List

```csharp
Debug.Assert(CombinationsColors(new string[] { "Red", "Green", "Blue" }, 1).SequenceEqual(new Tuple<string>[] { Tuple.Create("Red"), Tuple.Create("Green"), Tuple.Create("Blue") }));
```

```csharp
Debug.Assert(CombinationsColors(new List<string> {"Red", "Green", "Blue"}, 2).SequenceEqual(new List<(string, string)> { ("Red", "Red"), ("Red", "Green"), ("Red", "Blue"), ("Green", "Green"), ("Green", "Blue"), ("Blue", "Blue") }));
```

```csharp
Debug.Assert(CombinationsColors(new string[] { "Red", "Green", "Blue" }, 3).SequenceEqual(new Tuple<string, string, string>[] {
    Tuple.Create("Red", "Red", "Red"), 
    Tuple.Create("Red", "Red", "Green"), 
    Tuple.Create("Red", "Red", "Blue"), 
    Tuple.Create("Red", "Green", "Green"), 
    Tuple.Create("Red", "Green", "Blue"), 
    Tuple.Create("Red", "Blue", "Blue"), 
    Tuple.Create("Green", "Green", "Green"), 
    Tuple.Create("Green", "Green", "Blue"), 
    Tuple.Create("Green", "Blue", "Blue"), 
    Tuple.Create("Blue", "Blue", "Blue") 
}));
```
