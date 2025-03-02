# mbcp-41 -- Filter even numbers with a lambda function

## Text

Write a function to filter even numbers using lambda function.

## Code

```csharp
public List<int> FilterEvenNumbers(List<int> nums)
{
    List<int> evenNums = nums.Where(x => x % 2 == 0).ToList();
    return evenNums;
}
```

## Test List

```csharp
Debug.Assert(FilterEvenNumbers(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).SequenceEqual(new List<int> { 2, 4, 6, 8, 10 }));

public List<int> FilterEvenNumbers(List<int> numbers) {
    return numbers.Where(n => n % 2 == 0).ToList();
}
```

```csharp
Debug.Assert(FilterEvenNumbers(new List<int> { 10, 20, 45, 67, 84, 93 }).SequenceEqual(new List<int> { 10, 20, 84 }));
```

```csharp
Debug.Assert(FilterEvenNumbers(new List<int> { 5, 7, 9, 8, 6, 4, 3 }).SequenceEqual(new List<int> { 8, 6, 4 }));

public static List<int> FilterEvenNumbers(List<int> numbers) {
    return numbers.Where(n => n % 2 == 0).ToList();
}
```
