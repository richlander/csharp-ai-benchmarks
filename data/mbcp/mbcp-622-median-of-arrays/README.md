# mbcp622 -- Find median of two equal-sized sorted arrays

## Text

Write a function to find the median of two sorted arrays of same size.

## Code

```csharp
public double GetMedian(int[] arr1, int[] arr2, int n)
{
    int i = 0;
    int j = 0;
    int m1 = -1;
    int m2 = -1;
    int count = 0;
    while (count < n + 1)
    {
        count++;
        if (i == n)
        {
            m1 = m2;
            m2 = arr2[0];
            break;
        }
        else if (j == n)
        {
            m1 = m2;
            m2 = arr1[0];
            break;
        }
        if (arr1[i] <= arr2[j])
        {
            m1 = m2;
            m2 = arr1[i];
            i++;
        }
        else
        {
            m1 = m2;
            m2 = arr2[j];
            j++;
        }
    }
    return (m1 + m2) / 2.0;
}
```

## Test List

```csharp
Debug.Assert(GetMedian(new int[] { 1, 12, 15, 26, 38 }, new int[] { 2, 13, 17, 30, 45 }, 5) == 16.0);
```

```csharp
Debug.Assert(GetMedian(new int[] { 2, 4, 8, 9 }, new int[] { 7, 13, 19, 28 }, 4) == 8.5);
```

```csharp
Debug.Assert(GetMedian(new int[] { 3, 6, 14, 23, 36, 42 }, new int[] { 2, 18, 27, 39, 49, 55 }, 6) == 25.0);
```
