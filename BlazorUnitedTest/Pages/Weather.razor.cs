namespace BlazorUnitedTest.Pages;

public partial class Weather
{
    private static readonly string[] Summaries =
    [
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching",
    ];

    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        // Simulate retrieving the data asynchronously.
        await Task.Delay(1000);
        var startDate = DateOnly.FromDateTime(DateTime.Now);
        forecasts = Enumerable.Range(1, 5)
            .Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();
    }
}
