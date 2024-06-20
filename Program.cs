using WeatherGenerator;


var now = DateTime.Now; // use today's date
var day = new DateTime(now.Year, now.Month, now.Day);

for (int hour = 0; hour < 24; hour++) // do 24 hours
{
    Console.WriteLine(day.ToString("yyyy-MM-dd HH:mmUTC"));

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(
            $"{Forecast.RandomLatitude()}\t" +
            $"{Forecast.RandomLongitude()}\t" +
            $"{Forecast.RandomTemperature()}\t" +
            $"{Forecast.RandomWindSpeed()}\tkm/h\t" +
            $"{Forecast.RandomDirection()}\t" +
            $"{Forecast.RandomPrecipitation()}");
    }
    day = day.AddHours(1);
}