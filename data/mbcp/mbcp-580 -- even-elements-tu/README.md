# mbcp-580 -- Extract even elements from nested mixed tuple

## Text

Write a function to extract the even elements in the nested mixed tuple.

## Code

```csharp
public static Tuple<object> EvenEle(Tuple<object> testTuple, Func<object, bool> evenFnc) 
{
    var res = new List<object>();
    foreach (var ele in testTuple)
    {
        if (ele is Tuple<object> nestedTuple)
        {
            res.Add(EvenEle(nestedTuple, evenFnc));
        }
        else if (evenFnc(ele))
        {
            res.Add(ele);
        }
    }
    return Tuple.Create(res.ToArray());
}

public static Tuple<object> ExtractEven(Tuple<object> testTuple) 
{
    var res = EvenEle(testTuple, x => (int)x % 2 == 0);
    return res;
}
```

## Test List

```csharp
Debug.Assert(ExtractEven(new object[] { 4, 5, new object[] { 7, 6, new object[] { 2, 4 } }, 6, 8 }).Equals(new object[] { 4, new object[] { 6, new object[] { 2, 4 } }, 6, 8 }));
```

```csharp
Debug.Assert(ExtractEven(new Tuple<int, int, Tuple<int, int, Tuple<int, int>>>(
    5, 6, new Tuple<int, int, Tuple<int, int>>(8, 7, new Tuple<int, int>(4, 8))
)) == new Tuple<int, Tuple<int, Tuple<int, int>>>(
    6, new Tuple<int, Tuple<int>>(8, new Tuple<int>(4, 8))
));
```

```csharp
Debug.Assert(ExtractEven((5, 6, (9, 8, (4, 6)), 8, 10)).Equals((6, (8, (4, 6)), 8, 10)));
```
