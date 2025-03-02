# mbcp598 -- Check if a number is an Armstrong number

## Text

Write a function to check whether the given number is armstrong or not.

## Code

```csharp
public bool ArmstrongNumber(int number) {
    int sum = 0;
    int times = 0;
    int temp = number;
    
    while (temp > 0) {
        times++;
        temp /= 10;
    }
    
    temp = number;
    while (temp > 0) {
        int reminder = temp % 10;
        sum += (int)Math.Pow(reminder, times);
        temp /= 10;
    }
    
    return number == sum;
}
```

## Test List

```csharp
Debug.Assert(ArmstrongNumber(153) == true);
```

```csharp
Debug.Assert(ArmstrongNumber(259) == false);
```

```csharp
Debug.Assert(ArmstrongNumber(4458) == false);
```
