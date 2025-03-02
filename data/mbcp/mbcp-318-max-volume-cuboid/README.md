# mbcp318 -- Find maximum cuboid volume from side sums

## Text

Write a C# function to find the maximum volume of a cuboid with given sum of sides.

## Code

```csharp
public static int MaxVolume(int s) 
{ 
    int maxvalue = 0; 
    for (int i = 1; i < s - 1; i++) 
    { 
        for (int j = 1; j < s; j++) 
        { 
            int k = s - i - j; 
            maxvalue = Math.Max(maxvalue, i * j * k); 
        } 
    } 
    return maxvalue; 
}
```

## Test List

```csharp
Debug.Assert(MaxVolume(8) == 18);
```

```csharp
Debug.Assert(MaxVolume(4) == 2);
```

```csharp
Debug.Assert(MaxVolume(1) == 0);
```
