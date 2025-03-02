# mbcp-270 -- Sum even numbers at even indices in a list

## Text

Write a C# function to find the sum of even numbers at even positions.

## Code

```csharp
public int SumEvenAndEvenIndex(int[] arr, int n)  
{  
    int sum = 0;  
    for (int i = 0; i < n; i += 2)  
    {  
        if (arr[i] % 2 == 0)  
        {  
            sum += arr[i];  
        }  
    }  
    return sum;  
}
```

## Test List

```csharp
Debug.Assert(SumEvenAndEvenIndex(new int[] { 5, 6, 12, 1, 18, 8 }, 6) == 30);
```

```csharp
Debug.Assert(SumEvenAndEvenIndex(new int[] { 3, 20, 17, 9, 2, 10, 18, 13, 6, 18 }, 10) == 26);
```

```csharp
Debug.Assert(SumEvenAndEvenIndex(new int[] { 5, 6, 12, 1 }, 4) == 12);
```
