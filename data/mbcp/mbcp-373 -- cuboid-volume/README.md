# mbcp-373 -- Calculate the volume of a cuboid using a function

## Text

Write a function to find the volume of a cuboid.

## Code

```csharp
public static int VolumeCuboid(int l, int w, int h)  
{  
    int volume = l * w * h;  
    return volume;  
}
```

## Test List

```csharp
Debug.Assert(VolumeCuboid(1, 2, 3) == 6);
```

```csharp
Debug.Assert(VolumeCuboid(5, 7, 9) == 315);
```

```csharp
Debug.Assert(VolumeCuboid(10, 15, 21) == 3150);
```
