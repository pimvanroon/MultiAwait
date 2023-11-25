using CoolMultipleAwaits;

var service = new WeatherService();

Console.WriteLine(TimeProvider.System.GetLocalNow());

var (london, paris) = await (service.GetWeather(), service.GetWeather());
Console.WriteLine("London:", london);
Console.WriteLine("Paris:", paris);
Console.WriteLine(TimeProvider.System.GetLocalNow());

Console.WriteLine();
