# mbcp-553 -- Convert tuple to floating-point number function

## Text

Write a function to convert the given tuple to a floating-point number.

## Code

```csharp
float TupleToFloat(ValueTuple<float, float> testTup) 
{
    string res = string.Join(".", testTup.Item1.ToString(), testTup.Item2.ToString());
    return float.Parse(res);
}
```

## Test List

```csharp
Debug.Assert(TupleToFloat((4, 56)) == 4.56f);
```

```csharp
Debug.Assert(TupleToFloat((7, 256)) == 7.256f);
```

```csharp
Debug.Assert(TupleToFloat((8, 123)) == 8.123f);
```
