# mbcp-419 -- Round list numbers and print total times length

## Text

Write a function to round every number of a given list of numbers and print the total sum multiplied by the length of the list.

## Code

```csharp
public static double RoundAndSum(List<double> list1)
{
    int length = list1.Count;
    double roundAndSum = list1.Sum(x => Math.Round(x)) * length;
    return roundAndSum;
}
```

## Test List

```csharp
Debug.Assert(RoundAndSum(new double[] { 22.4, 4.0, -16.22, -9.10, 11.00, -12.22, 14.20, -5.20, 17.50 }) == 243);
```

```csharp
Debug.Assert(RoundAndSum(new double[] { 5, 2, 9, 24.3, 29 }) == 345);
```

```csharp
Debug.Assert(RoundAndSum(new double[] { 25.0, 56.7, 89.2 }) == 513);
```
