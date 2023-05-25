namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(74); 
            var fahrenheit = TempConverter.CelsiusToFahrenheit(22); 

            Console.WriteLine("Display temperature in celsius and fahrenheit:\n");
            Console.WriteLine($"74 degrees fahrenheit in celsius is: {celsius} degrees celsius.\n");
            Console.WriteLine($"22 degrees celsius in fahrenheit is: {fahrenheit} degrees fahrenheit.");
        }
    }
}
