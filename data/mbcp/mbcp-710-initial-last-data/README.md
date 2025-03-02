# mbcp710 -- Access first and last elements of a tuple record

## Text

Write a function to access the initial and last data of the given tuple record.

## Code

```csharp
public static Tuple<object, object> FrontAndRear(Tuple<object, object> testTup)  
{  
    var res = Tuple.Create(testTup.Item1, testTup.Item2);  
    return res;  
}
```

## Test List

```csharp
Debug.Assert(FrontAndRear(new int[] { 10, 4, 5, 6, 7 }).SequenceEqual(new int[] { 10, 7 }));
```

```csharp
Debug.Assert(FrontAndRear(new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5)).Item1 == 1 && FrontAndRear(new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5)).Item2 == 5);
```

```csharp
Debug.Assert(FrontAndRear(new Tuple<int, int, int, int, int>(6, 7, 8, 9, 10)).Equals(new Tuple<int, int>(6, 10)));
```
