# mbcp701 -- Find the equilibrium index in an array

## Text

Write a function to find the equilibrium index of the given array.

## Code

```csharp
public int EquilibriumIndex(int[] arr)
{
    int totalSum = arr.Sum();
    int leftSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        totalSum -= arr[i];
        if (leftSum == totalSum)
        {
            return i;
        }
        leftSum += arr[i];
    }
    return -1;
}
```

## Test List

```csharp
Debug.Assert(EquilibriumIndex(new int[] { 1, 2, 3, 4, 1, 2, 3 }) == 3);
```

```csharp
Debug.Assert(EquilibriumIndex(new int[] { -7, 1, 5, 2, -4, 3, 0 }) == 3);
```

```csharp
Debug.Assert(EquilibriumIndex(new int[] { 1, 2, 3 }) == -1);
```
