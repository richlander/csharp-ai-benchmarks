# mbcp-692 -- Last two digits of factorial in Python function

## Text

Write a C# function to find the last two digits in factorial of a given number.

## Code

```csharp
public int LastTwoDigits(int N) 
{ 
    if (N >= 10) 
    { 
        return 0; 
    } 
    int fac = 1; 
    for (int i = 1; i <= N; i++) 
    { 
        fac = (fac * i) % 100; 
    } 
    return fac; 
}
```

## Test List

```csharp
Debug.Assert(LastTwoDigits(7) == 40);
```

```csharp
Debug.Assert(LastTwoDigits(5) == 20);
```

```csharp
Debug.Assert(LastTwoDigits(2) == 2);
```
