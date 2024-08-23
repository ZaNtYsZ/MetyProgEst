namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introuzca el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;

            Console.WriteLine("La suma de los dos numeros ingresados son: " + suma);
        }
    }
}
