# mbcp-770 -- Sum of fourth powers of first n odd numbers

## Text

Write a C# function to find the sum of fourth power of first n odd natural numbers.

## Code

```csharp
public int OddNumSum(int n) 
{ 
    int j = 0; 
    int sm = 0; 
    for (int i = 1; i <= n; i++) 
    { 
        j = (2 * i - 1); 
        sm += (j * j * j * j); 
    } 
    return sm; 
}
```

## Test List

```csharp
Debug.Assert(OddNumSum(2) == 82);
```

```csharp
Debug.Assert(OddNumSum(3) == 707);
```

```csharp
Debug.Assert(OddNumSum(4) == 3108);
```
