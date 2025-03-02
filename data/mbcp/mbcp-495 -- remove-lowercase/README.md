# mbcp-495 -- Remove lowercase substrings using regex function

## Text

Write a function to remove lowercase substrings from a given string by using regex.

## Code

```csharp
public string RemoveLowercase(string str1) {
    Func<string, string> removeLower = text => Regex.Replace(text, "[a-z]", "");
    string result = removeLower(str1);
    return result;
}
```

## Test List

```csharp
Debug.Assert(RemoveLowercase("KDeoALOklOOHserfLoAJSIskdsf") == "KDALOOOHLAJSI");
```

```csharp
Debug.Assert(RemoveLowercase("ProducTnamEstreAmIngMediAplAYer") == "PTEAIMAAY");
```

```csharp
Debug.Assert(RemoveLowercase("maNufacTuredbYSheZenTechNolOGIes") == "NTYSZTNOGI");
```
