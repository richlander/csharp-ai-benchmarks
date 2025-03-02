# mbcp-724 -- Sum digits of a number raised to a power

## Text

Write a function to calculate the sum of all digits of the base to the specified power.

## Code

```csharp
public int PowerBaseSum(int base, int power)
{
    return str(pow(base, power)).ToCharArray().Sum(c => (int)char.GetNumericValue(c));
}
```

## Test List

```csharp
Debug.Assert(PowerBaseSum(2, 100) == 115);
```

```csharp
Debug.Assert(PowerBaseSum(8, 10) == 37);
```

```csharp
Debug.Assert(PowerBaseSum(8, 15) == 62);
```
