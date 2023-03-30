using System;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace _2_6
{
    class Program
    {
        static WeatherData GetWeathertoday(string request)
        {
            return JsonConvert.DeserializeObject<WeatherData>(request);
        }
        static void Main()
        {
            string url;
            string town;
            string text = "Прогноз погоды\n";
            Console.SetCursorPosition(50, 0);
            Console.Write(text);
            Console.WriteLine("Введите город: ");
                        town = Console.ReadLine();
                        url = $"https://api.openweathermap.org/data/2.5/weather?q={town}&lang=ru&appid=918b97276d8773fbec99bd15e99e067d&units=metric";
                        WeatherData weatherToday = GetWeathertoday(GetContent(url));
                        Console.WriteLine(
                            $"\nПрогноз погоды для {weatherToday.name} '{weatherToday.sys.country}':\nПогода - {weatherToday.weather[0].main} {weatherToday.weather[0].description}\nТемпература: {weatherToday.main.temp}°C Ощущается как: {weatherToday.main.feels_like}°C\nСкорость ветра - {weatherToday.wind.speed} м/с");
        }
        static string GetContent(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream()!);
            StringBuilder output = new StringBuilder();
            output.Append(reader.ReadToEnd());
            response.Close();
            return output.ToString();
        }
    }
}
