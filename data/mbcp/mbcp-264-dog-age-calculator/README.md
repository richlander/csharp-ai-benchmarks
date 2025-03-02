# mbcp264 -- Calculate a dog's age in dog years

## Text

Write a function to calculate a dog's age in dog's years.

## Code

```csharp
public double DogAge(double h_age)
{
    if (h_age < 0)
    {
        Environment.Exit(0);
    }
    else if (h_age <= 2)
    {
        return h_age * 10.5;
    }
    else
    {
        return 21 + (h_age - 2) * 4;
    }
}
```

## Test List

```csharp
Debug.Assert(DogAge(12) == 61);
```

```csharp
Debug.Assert(DogAge(15) == 73);
```

```csharp
Debug.Assert(DogAge(24) == 109);
```
