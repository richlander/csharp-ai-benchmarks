# mbcp525 -- Check if two lines are parallel in Python

## Text

Write a C# function to check whether two given lines are parallel or not.

## Code

```csharp
public bool ParallelLines(double[] line1, double[] line2) {
    return line1[0] / line1[1] == line2[0] / line2[1];
}
```

## Test List

```csharp
Debug.Assert(ParallelLines(new int[] { 2, 3, 4 }, new int[] { 2, 3, 8 }) == true);
```

```csharp
Debug.Assert(ParallelLines(new int[] { 2, 3, 4 }, new int[] { 4, -3, 8 }) == false);
```

```csharp
Debug.Assert(ParallelLines(new int[] { 3, 3 }, new int[] { 5, 5 }) == true);
```
