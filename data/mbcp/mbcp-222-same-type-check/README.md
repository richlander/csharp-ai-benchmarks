# mbcp222 -- Check if tuple elements share the same type

## Text

Write a function to check if all the elements in tuple have same data type or not.

## Code

```csharp
public bool CheckType(Tuple<object> testTuple)  
{  
    bool res = true;  
    foreach (var ele in testTuple)  
    {  
        if (ele.GetType() != testTuple.Item1.GetType())  
        {  
            res = false;  
            break;  
        }  
    }  
    return res;  
}
```

## Test List

```csharp
Debug.Assert(CheckType(new Tuple<int, int, int, int, int, int>(5, 6, 7, 3, 5, 6)) == true);
```

```csharp
Debug.Assert(CheckType((1, 2, "4")) == false);
```

```csharp
Debug.Assert(CheckType(new Tuple<int, int, int, int, int>(3, 2, 1, 4, 5)) == true);
```
