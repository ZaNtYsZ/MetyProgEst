namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el radio de un circulo: ");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radio, 2);
         
            Console.WriteLine("El area calculado del circulo con radio {0} es: {1}", radio, area);
            
        }

    }
}