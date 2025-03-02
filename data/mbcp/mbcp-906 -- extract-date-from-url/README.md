# mbcp-906 -- Extract date components from a URL using regex

## Text

Write a function to extract year, month and date from a url by using regex.

## Code

```csharp
public List<(int, int, int)> ExtractDate(string url) 
{
    var regex = new Regex(@"/(\d{4})/(\d{1,2})/(\d{1,2})/");
    var matches = regex.Matches(url);
    var dates = new List<(int, int, int)>();

    foreach (Match match in matches)
    {
        int year = int.Parse(match.Groups[1].Value);
        int month = int.Parse(match.Groups[2].Value);
        int day = int.Parse(match.Groups[3].Value);
        dates.Add((year, month, day));
    }

    return dates;
}
```

## Test List

```csharp
Debug.Assert(ExtractDate("https://www.washingtonpost.com/news/football-insider/wp/2016/09/02/odell-beckhams-fame-rests-on-one-stupid-little-ball-josh-norman-tells-author/").SequenceEqual(new Tuple<string, string, string>[] { Tuple.Create("2016", "09", "02") }));
```

```csharp
Debug.Assert(ExtractDate("https://www.indiatoday.in/movies/celebrities/story/wp/2020/11/03/odeof-sushant-singh-rajput-s-death-his-brother-in-law-shares-advice-for-fans-1749646/").SequenceEqual(new List<Tuple<string, string, string>> { Tuple.Create("2020", "11", "03") }));
```

```csharp
Debug.Assert(ExtractDate("https://economictimes.indiatimes.com/news/economy/2020/12/29/finance/pension-assets-under-pfrda-touch-rs-5-32-lakh-crore/articleshow/79736619.cms").SequenceEqual(new List<Tuple<string, string, string>> { Tuple.Create("2020", "12", "29") }));
```
