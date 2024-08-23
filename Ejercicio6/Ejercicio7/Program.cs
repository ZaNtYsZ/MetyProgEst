namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero {0} es par...", numero);
            }

            else
            {
                Console.WriteLine("El numero {0} es impar...", numero);
            }

        }
    }
}
