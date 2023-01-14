namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(65);
            Console.WriteLine($"celcius {celcius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
