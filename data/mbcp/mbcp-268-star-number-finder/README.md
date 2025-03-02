# mbcp268 -- Calculate the nth star number in a sequence

## Text

Write a function to find the n'th star number.

## Code

```csharp
public int FindStarNum(int n)  
{  
    return (6 * n * (n - 1) + 1);  
}
```

## Test List

```csharp
Debug.Assert(FindStarNum(3) == 37);
```

```csharp
Debug.Assert(FindStarNum(4) == 73);
```

```csharp
Debug.Assert(FindStarNum(5) == 121);
```
