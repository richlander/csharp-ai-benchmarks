# mbcp-433 -- Check if a number exceeds array elements

## Text

Write a function to check whether the entered number is greater than the elements of the given array.

## Code

```csharp
public string CheckGreater(List<int> arr, int number)
{
    arr.Sort();
    if (number > arr[arr.Count - 1])
    {
        return "Yes, the entered number is greater than those in the array";
    }
    else
    {
        return "No, entered number is less than those in the array";
    }
}
```

## Test List

```csharp
Debug.Assert(CheckGreater(new int[] { 1, 2, 3, 4, 5 }, 4) == "No, entered number is less than those in the array");
```

```csharp
CheckGreater(new int[] { 2, 3, 4, 5, 6 }, 8);  
Debug.Assert(CheckGreater(new int[] { 2, 3, 4, 5, 6 }, 8) == "Yes, the entered number is greater than those in the array");
```

```csharp
Debug.Assert(CheckGreater(new int[] { 9, 7, 4, 8, 6, 1 }, 11) == "Yes, the entered number is greater than those in the array");

public static string CheckGreater(int[] numbers, int numberToCheck)
{
    foreach (var number in numbers)
    {
        if (number >= numberToCheck)
        {
            return "No, the entered number is not greater than those in the array";
        }
    }
    return "Yes, the entered number is greater than those in the array";
}
```
