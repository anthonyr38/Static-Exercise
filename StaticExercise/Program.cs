namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68); // 20
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20); //68

            Console.WriteLine("Display temperature in celsius and fahrenheit:\n");
            Console.WriteLine($"celsius is: {celsius}\n");
            Console.WriteLine($"fahrenheit is: {fahrenheit}");
        }
    }
}
