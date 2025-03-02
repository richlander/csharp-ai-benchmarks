# mbcp-184 -- Find values in a list greater than a number

## Text

Write a function to find all the values in a list that are greater than a specified number.

## Code

```csharp
public bool GreaterSpecificNum(List<int> list, int num)  
{  
    return list.All(x => x >= num);  
}
```

## Test List

```csharp
Debug.Assert(GreaterSpecificNum(new int[] { 220, 330, 500 }, 200) == true);
```

```csharp
Debug.Assert(GreaterSpecificNum(new int[] { 12, 17, 21 }, 20) == false);
```

```csharp
Debug.Assert(GreaterSpecificNum(new int[] { 1, 2, 3, 4 }, 10) == false);
```
