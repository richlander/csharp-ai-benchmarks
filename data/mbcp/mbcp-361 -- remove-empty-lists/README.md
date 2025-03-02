# mbcp-361 -- Remove empty lists from a list of lists

## Text

Write a function to remove empty lists from a given list of lists.

## Code

```csharp
public List<T> RemoveEmpty<T>(List<T> list1) {
    List<T> removeEmpty = list1.Where(x => !EqualityComparer<T>.Default.Equals(x, default(T))).ToList();
    return removeEmpty;
}
```

## Test List

```csharp
Debug.Assert(RemoveEmpty(new object[][] { new object[] {}, new object[] {}, new object[] {}, "Red", "Green", new object[] { 1, 2 }, "Blue", new object[] {}, new object[] {} }).SequenceEqual(new object[] { "Red", "Green", new object[] { 1, 2 }, "Blue" }));
```

```csharp
Debug.Assert(RemoveEmpty(new object[][] { new object[] { }, new object[] { }, new object[] { }, new object[] { }, new object[] { }, "Green", new object[] { 1, 2 }, "Blue", new object[] { }, new object[] { } }).SequenceEqual(new object[] { "Green", new object[] { 1, 2 }, "Blue" }));
```

```csharp
Debug.Assert(RemoveEmpty(new object[][] { new object[0], new object[0], new object[0], "Python", new object[0], new object[0], "programming", "language", new object[0], new object[0], new object[0], new object[0], new object[0] }).SequenceEqual(new string[] { "Python", "programming", "language" }));
```
