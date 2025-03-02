# mbcp959 -- Calculate the average of numbers in a list

## Text

Write a C# function to find the average of a list.

## Code

```csharp
public static double Average(List<double> lst) 
{ 
    return lst.Sum() / lst.Count; 
}
```

## Test List

```csharp
Debug.Assert(Average(new double[] { 15, 9, 55, 41, 35, 20, 62, 49 }) == 35.75);
```

```csharp
Debug.Assert(Average(new double[] { 4, 5, 1, 2, 9, 7, 10, 8 }) == 5.75);
```

```csharp
Debug.Assert(Average(new int[]{1, 2, 3}) == 2);
```
