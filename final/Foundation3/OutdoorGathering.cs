using System.Net.Http;

public class OutdoorGathering : Event
{
    public OutdoorGathering(string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {
    }

    public override string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.Street}, {_address.City}, {_address.State} {_address.ZipCode}\nType: Outdoor Gathering\nWeather Forecast: {GetWeatherForecast()}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {_title}\nDate: {_date}";
    }

    private string GetWeatherForecast()
    {
        // Dummy weather API call, replace with real API call if available
       var response = new HttpClient().GetStringAsync("https:api.weather.com/forecast").Result;
        return $"Weather Forecast: {response}";
    }
}
