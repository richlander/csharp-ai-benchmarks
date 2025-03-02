# mbcp213 -- Concatenate two tuples of strings into one

## Text

Write a function to perform the concatenation of two string tuples.

## Code

```csharp
public static Tuple<string> ConcatenateStrings(Tuple<string> testTup1, Tuple<string> testTup2) {
    var res = Tuple.Create(testTup1.Item1 + testTup2.Item1, testTup1.Item2 + testTup2.Item2);
    return res;
}
```

## Test List

```csharp
Debug.Assert(ConcatenateStrings(new string[] { "Manjeet", "Nikhil", "Akshat" }, new string[] { " Singh", " Meherwal", " Garg" }).SequenceEqual(new string[] { "Manjeet Singh", "Nikhil Meherwal", "Akshat Garg" }));
```

```csharp
Debug.Assert(ConcatenateStrings(new string[] { "Shaik", "Ayesha", "Sanya" }, new string[] { " Dawood", " Begum", " Singh" }) == new string[] { "Shaik Dawood", "Ayesha Begum", "Sanya Singh" });
```

```csharp
Debug.Assert(ConcatenateStrings(("Harpreet", "Priyanka", "Muskan"), ("Kour", " Agarwal", "Sethi")) == ("HarpreetKour", "Priyanka Agarwal", "MuskanSethi"));
```
