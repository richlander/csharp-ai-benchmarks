# mbcp117 -- Convert list elements to float when possible

## Text

Write a function to convert all possible convertible elements in the list to float.

## Code

```csharp
public static string ListToFloat(List<(string, string)> testList)
{
    List<(string, string)> res = new List<(string, string)>();
    foreach (var tup in testList)
    {
        List<object> temp = new List<object>();
        foreach (var ele in tup)
        {
            if (double.TryParse(ele, out _))
            {
                temp.Add(double.Parse(ele));
            }
            else
            {
                temp.Add(ele);
            }
        }
        res.Add(((string)temp[0], (string)temp[1]));
    }
    return res.ToString();
}
```

## Test List

```csharp
Debug.Assert(ListToFloat(new List<Tuple<string, string>> { Tuple.Create("3", "4"), Tuple.Create("1", "26.45"), Tuple.Create("7.32", "8"), Tuple.Create("4", "8") }) == "[(3.0, 4.0), (1.0, 26.45), (7.32, 8.0), (4.0, 8.0)]");
```

```csharp
Debug.Assert(ListToFloat(new List<Tuple<string, string>> { Tuple.Create("4", "4"), Tuple.Create("2", "27"), Tuple.Create("4.12", "9"), Tuple.Create("7", "11") }) == "[(4.0, 4.0), (2.0, 27.0), (4.12, 9.0), (7.0, 11.0)]");
```

```csharp
Debug.Assert(ListToFloat(new List<Tuple<string, string>> { Tuple.Create("6", "78"), Tuple.Create("5", "26.45"), Tuple.Create("1.33", "4"), Tuple.Create("82", "13") }) == "[ (6.0, 78.0), (5.0, 26.45), (1.33, 4.0), (82.0, 13.0) ]");
```
