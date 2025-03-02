# mbcp411 -- Convert snake case to camel case using regex

## Text

Write a function to convert the given snake case string to camel case string by using regex.

## Code

```csharp
public string SnakeToCamel(string word) {
    return string.Concat(word.Split('_').Select(x => char.ToUpper(x[0]) + x.Substring(1)));
}
```

## Test List

```csharp
Debug.Assert(SnakeToCamel("android_tv") == "AndroidTv");
```

```csharp
Debug.Assert(SnakeToCamel("google_pixel") == "GooglePixel");
```

```csharp
Debug.Assert(SnakeToCamel("apple_watch") == "AppleWatch");
```
