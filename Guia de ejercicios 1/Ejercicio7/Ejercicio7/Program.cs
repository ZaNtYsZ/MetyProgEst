namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Escribe un programa que lea tres números enteros y determine cuál de ellos es el mayor.
            
            Console.Write("Ingrese el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            int mayor;

            if (num1 > num2 && num1 > num3)
            {
                mayor = num1;
            }

            else if (num2 > num1 && num2 > num3)
            {
                mayor = num2;
            }

            else
            {
                mayor = num3;
            }

            Console.WriteLine("El numero mayor es: " + mayor);
        }
    }
}
