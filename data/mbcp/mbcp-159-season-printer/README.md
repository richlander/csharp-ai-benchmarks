# mbcp159 -- Print season based on given month and day

## Text

Write a function to print the season for the given month and day.

## Code

```csharp
public string MonthSeason(string month, int days) {
    string season;
    if (month == "January" || month == "February" || month == "March") {
        season = "winter";
    } else if (month == "April" || month == "May" || month == "June") {
        season = "spring";
    } else if (month == "July" || month == "August" || month == "September") {
        season = "summer";
    } else {
        season = "autumn";
    }
    
    if (month == "March" && days > 19) {
        season = "spring";
    } else if (month == "June" && days > 20) {
        season = "summer";
    } else if (month == "September" && days > 21) {
        season = "autumn";
    } else if (month == "October" && days > 21) {
        season = "autumn";
    } else if (month == "November" && days > 21) {
        season = "autumn";
    } else if (month == "December" && days > 20) {
        season = "winter";
    }
    
    return season;
}
```

## Test List

```csharp
Debug.Assert(MonthSeason("January", 4) == "winter");
```

```csharp
Debug.Assert(MonthSeason("October", 28) == "autumn");
```

```csharp
Debug.Assert(MonthSeason("June", 6) == "spring");
```
