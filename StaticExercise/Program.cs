namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(74); 
            var fahrenheit = TempConverter.CelsiusToFahrenheit(22); 

            Console.WriteLine("Display temperature in celsius and fahrenheit:\n");
            Console.WriteLine($"celsius is: {celsius}\n");
            Console.WriteLine($"fahrenheit is: {fahrenheit}");
        }
    }
}
