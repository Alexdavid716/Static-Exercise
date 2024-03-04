using System;

class Program
{
    static void Main(string[] args)
    {
        double fahrenheit = 98.6;
        double celsius = TempConverter.FahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {celsius:F2} Celsius.");

        celsius = 37;
        fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius} Celsius is equal to {fahrenheit:F2} Fahrenheit.");
    }
}