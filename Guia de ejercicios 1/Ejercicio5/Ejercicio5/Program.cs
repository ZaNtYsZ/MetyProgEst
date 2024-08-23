namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre del trabajador: ");
            string nombre = Console.ReadLine();
            Console.Write("Cargo del trabajador: ");
            string cargo = Console.ReadLine();
            Console.Write("Salario del trabajador: ");
            double salario = double.Parse(Console.ReadLine());

            //
            double aumento = salario * 0.10;

            double SalarioNuevo = salario + aumento;

            Console.WriteLine("\nDatos del Trabajador ingresado:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Salario Actual: " + salario);
            Console.WriteLine("Aumento del 10%: " + aumento);
            Console.WriteLine("Nuevo Salario: " + SalarioNuevo);
        }
}   }
