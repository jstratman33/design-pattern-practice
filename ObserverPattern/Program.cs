using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var stLouisWeatherStation = new WeatherStation();
            var kansasCityWeatherStation = new WeatherStation();

            var myPhone = new PhoneApp(stLouisWeatherStation);
            var yourPhone = new PhoneApp(kansasCityWeatherStation);
            var myDevice = new SmartDevice(stLouisWeatherStation);
            var yourDevice = new SmartDevice(kansasCityWeatherStation);

            Console.WriteLine("My Phone:");
            myPhone.Display();
            Console.WriteLine("Your Phone:");
            yourPhone.Display();
            Console.WriteLine("My Device:");
            myDevice.Display();
            Console.WriteLine("Your Device:");
            yourDevice.Display();

            Console.WriteLine("Register subscribers");
            stLouisWeatherStation.Register(myPhone);
            stLouisWeatherStation.Register(myDevice);
            kansasCityWeatherStation.Register(yourPhone);
            kansasCityWeatherStation.Register(yourDevice);

            Console.WriteLine("My Phone:");
            myPhone.Display();
            Console.WriteLine("Your Phone:");
            yourPhone.Display();
            Console.WriteLine("My Device:");
            myDevice.Display();
            Console.WriteLine("Your Device:");
            yourDevice.Display();

            Console.WriteLine("Temperature in St. Louis changes to 72.3");
            Console.WriteLine("Humidity in St. Louis changes to 42.1");
            stLouisWeatherStation.Temperature = 72.3M;
            stLouisWeatherStation.Humidity = 42.1M;

            Console.WriteLine("My Phone:");
            myPhone.Display();
            Console.WriteLine("Your Phone:");
            yourPhone.Display();
            Console.WriteLine("My Device:");
            myDevice.Display();
            Console.WriteLine("Your Device:");
            yourDevice.Display();

            Console.WriteLine("Temperature in Kansas City changes to 73.8");
            Console.WriteLine("Humidity in Kansas City changes to 41.3");
            kansasCityWeatherStation.Temperature = 73.8M;
            kansasCityWeatherStation.Humidity = 41.3M;

            Console.WriteLine("My Phone:");
            myPhone.Display();
            Console.WriteLine("Your Phone:");
            yourPhone.Display();
            Console.WriteLine("My Device:");
            myDevice.Display();
            Console.WriteLine("Your Device:");
            yourDevice.Display();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
