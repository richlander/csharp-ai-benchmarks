# mbcp549 -- Sum fifth powers of first n odd numbers

## Text

Write a C# function to find the sum of fifth power of first n odd natural numbers.

## Code

```csharp
public int OddNumSum(int n) 
{
    int j = 0;
    int sm = 0;
    for (int i = 1; i <= n; i++)
    {
        j = (2 * i - 1);
        sm += (j * j * j * j * j);
    }
    return sm;
}
```

## Test List

```csharp
Debug.Assert(OddNumSum(1) == 1);
```

```csharp
Debug.Assert(OddNumSum(2) == 244);
```

```csharp
Debug.Assert(OddNumSum(3) == 3369);
```
