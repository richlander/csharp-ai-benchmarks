# mbcp65 -- Recursive function to calculate list sum

## Text

Write a function of recursion list sum.

## Code

```csharp
public int RecursiveListSum(object dataList)
{
    int total = 0;
    foreach (var element in (System.Collections.IEnumerable)dataList)
    {
        if (element is System.Collections.IEnumerable && !(element is string))
        {
            total += RecursiveListSum(element);
        }
        else
        {
            total += Convert.ToInt32(element);
        }
    }
    return total;
}
```

## Test List

```csharp
Debug.Assert(RecursiveListSum(new object[] { 1, 2, new object[] { 3, 4 }, new object[] { 5, 6 } }) == 21);
```

```csharp
Debug.Assert(RecursiveListSum(new object[] { 7, 10, new object[] { 15, 14 }, new object[] { 19, 41 } }) == 106);
```

```csharp
Debug.Assert(RecursiveListSum(new object[] { 10, 20, new object[] { 30, 40 }, new object[] { 50, 60 } }) == 210);
```
