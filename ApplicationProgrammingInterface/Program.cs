using System.Dynamic;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

// dynamic a = 42;
//
// Console.WriteLine(a * 10);
//
// a = "hello";
//
// Console.WriteLine(a.IndexOf('l'));



var client = new WebClient();

try
{
    var response = client.DownloadString(
        "https://api.openweathermap.org/data/2.5/weather?q=Baku&appid={apiKey}");
    
    // (32°F − 32) × 5/9
    // Console.WriteLine((data.Main.Temp - 32)  / 1.8);
    // Console.WriteLine(data.Main.Temp - 273.15);
    // Console.WriteLine(data.Sys.Country);
    // Console.WriteLine(data.Sys.Sunrise);
    // Console.WriteLine(data.Sys.Sunset);
    //////////////
    // dynamic data = JsonSerializer.Deserialize<ExpandoObject>(response);

    //Console.WriteLine(JsonSerializer.Deserialize<ExpandoObject>(data.main).temp);

}
catch (WebException ex)
{
    Console.WriteLine(ex.Message);
}

// var httpClient = new HttpClient();
// var result = httpClient.GetAsync("https://api.openweathermap.org/data/2.5/weather?q=Baku&appid={apiKey}").GetAwaiter().GetResult();
// var data = result.Content.ReadFromJsonAsync<WeatherData>().GetAwaiter().GetResult();
//
// Console.WriteLine(data.Main.Temp);