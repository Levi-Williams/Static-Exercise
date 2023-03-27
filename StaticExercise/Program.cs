namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            TempConverter.CelciusToFarenheit(0);
            Console.WriteLine(TempConverter.CelciusToFarenheit(0));
            TempConverter.FarenheitToCelcius(32);
            Console.WriteLine(TempConverter.FarenheitToCelcius(32));
        }
    }
}
