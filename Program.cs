using WeatherGenerator;



Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mmUTC"));

for (int i = 0; i<10; i++)
{
    Console.WriteLine(
        $"{Forecast.RandomLatitude()}\t" +
        $"{Forecast.RandomLongitude()}\t" +
        $"{Forecast.RandomTemperature()}\t" +
        $"{Forecast.RandomWindSpeed()}\tkm/h\t" +
        $"{Forecast.RandomDirection()}\t" +
        $"{Forecast.RandomPrecipitation()}");
}
