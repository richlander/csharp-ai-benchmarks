# mbcp234 -- Calculate the volume of a cube given its side length

## Text

Write a function to find the volume of a cube.

## Code

```csharp
public int VolumeCube(int l)
{
    int volume = l * l * l;
    return volume;
}
```

## Test List

```csharp
Debug.Assert(VolumeCube(3) == 27);
```

```csharp
Debug.Assert(VolumeCube(2) == 8);
```

```csharp
Debug.Assert(VolumeCube(5) == 125);
```
