# mbcp558 -- Calculate digit distance between two integers

## Text

Write a C# function to find the digit distance between two integers.

## Code

```csharp
public int DigitDistanceNums(int n1, int n2)
{
    return n1.ToString().Length > n2.ToString().Length ? 
        n1.ToString().Length : n2.ToString().Length;
}
```

## Test List

```csharp
Debug.Assert(DigitDistanceNums(1, 2) == 1);
```

```csharp
Debug.Assert(DigitDistanceNums(23, 56) == 6);
```

```csharp
Debug.Assert(DigitDistanceNums(123, 256) == 7);
```
