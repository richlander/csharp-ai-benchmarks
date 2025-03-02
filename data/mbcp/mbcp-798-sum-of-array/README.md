# mbcp798 -- Calculate the sum of elements in an array

## Text

Write a C# function to find the sum of an array.

## Code

```csharp
public int Sum(int[] arr)  
{  
    int sum = 0;  
    foreach (int i in arr)  
    {  
        sum += i;  
    }  
    return sum;  
}
```

## Test List

```csharp
Debug.Assert(Sum(new int[] { 1, 2, 3 }) == 6);
```

```csharp
Debug.Assert(Sum(new int[] { 15, 12, 13, 10 }) == 50);
```

```csharp
Debug.Assert(Sum(new int[] { 0, 1, 2 }) == 3);
```
