# mbcp215 -- Decode a run-length encoded list into original values

## Text

Write a function to decode a run-length encoded given list.

## Code

```csharp
public List<int> DecodeList(List<object> alist) 
{
    List<int> Aux(object g) 
    {
        if (g is List<object> list)
        {
            return new List<int> { (int)list[1], (int)list[0] };
        }
        else
        {
            return new List<int> { (int)g, 0 };
        }
    }

    List<int> result = new List<int>();
    foreach (var g in alist) 
    {
        var auxResult = Aux(g);
        foreach (var x in auxResult) 
        {
            for (int i = 0; i < x; i++) 
            {
                result.Add(x);
            }
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(DecodeList(new object[][] { new object[] { 2, 1 }, 2, 3, new object[] { 2, 4 }, 5, 1 }).SequenceEqual(new List<int> { 1, 1, 2, 3, 4, 4, 5, 1 }));
```

```csharp
Debug.Assert(DecodeList(new object[] { 'a', 'u', 't', 'o', 'm', 'a', 't', 'i', 'c', 'a', new object[] { 2, 'l' }, 'y' }).SequenceEqual(new List<object> { 'a', 'u', 't', 'o', 'm', 'a', 't', 'i', 'c', 'a', 'l', 'l', 'y' }));
```

```csharp
Debug.Assert(DecodeList(new char[] { 'p', 'y', 't', 'h', 'o', 'n' }).SequenceEqual(new char[] { 'p', 'y', 't', 'h', 'o', 'n' }));
```
