# mbcp-717 -- Calculate standard deviation using a custom function

## Text

Write a function to calculate the standard deviation.

## Code

```csharp
using System;

public class Statistics
{
    public static double SdCalc(double[] data)
    {
        int n = data.Length;
        if (n <= 1)
        {
            return 0.0;
        }
        double mean = AvgCalc(data);
        double sd = 0.0;
        foreach (double el in data)
        {
            sd += (el - mean) * (el - mean);
        }
        sd = Math.Sqrt(sd / (n - 1));
        return sd;
    }

    public static double AvgCalc(double[] ls)
    {
        int n = ls.Length;
        double mean = 0.0;
        if (n <= 1)
        {
            return ls[0];
        }
        foreach (double el in ls)
        {
            mean += el;
        }
        mean /= n;
        return mean;
    }
}
```

## Test List

```csharp
Debug.Assert(SdCalc(new int[] { 4, 2, 5, 8, 6 }) == 2.23606797749979);
```

```csharp
Debug.Assert(SdCalc(new double[] { 1, 2, 3, 4, 5, 6, 7 }) == 2.160246899469287);
```

```csharp
Debug.Assert(SdCalc(new int[] { 5, 9, 10, 15, 6, 4 }) == 4.070217029430577);
```
