namespace StaticPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fahrenheit temperature:");
            double fahrenheitInput = double.Parse(Console.ReadLine());
            double celsiusResult = Math.Round(TempConverter.FahrenheitToCelsius(fahrenheitInput), 3);
            Console.WriteLine($"{fahrenheitInput} Fahrenheit equals {celsiusResult} Celsius");

            Console.WriteLine("Enter Celsius temperature:");
            double celsiusInput = double.Parse(Console.ReadLine());
            double fahrenheitResult = Math.Round(TempConverter.CelsiusToFahrenheit(celsiusInput), 3);
            Console.WriteLine($"{celsiusInput} Celsius equals {fahrenheitResult} Fahrenheit");
        }
    }
}
