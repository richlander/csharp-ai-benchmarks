# mbcp289 -- Calculate odd days in a given year using Python

## Text

Write a C# function to calculate the number of odd days in a given year.

## Code

```csharp
public int OddDays(int N) 
{ 
    int hund1 = N / 100; 
    int hund4 = N / 400; 
    int leap = N >> 2; 
    int ordd = N - leap; 
    if (hund1 != 0) 
    { 
        ordd += hund1; 
        leap -= hund1; 
    } 
    if (hund4 != 0) 
    { 
        ordd -= hund4; 
        leap += hund4; 
    } 
    int days = ordd + leap * 2; 
    int odd = days % 7; 
    return odd; 
}
```

## Test List

```csharp
Debug.Assert(OddDays(100) == 5);
```

```csharp
Debug.Assert(OddDays(50) == 6);
```

```csharp
Debug.Assert(OddDays(75) == 2);
```
