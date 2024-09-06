using sesion_5.models;

namespace sesion_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es niño, joven o adulto
            //niño: 0-12
            //joven: 18-25
            //adulto: 26 o mas 


            int edad = 0;
            evaluate evaluate = new evaluate();
            Console.WriteLine("Evaluar edad");
            Console.WriteLine("Ingrese su edad");
            try
            {
               edad convert.ToInt32(Console.ReadLine());
               Console.WriteLine(evaluate.EvalAge(edad));
            } catch (Exception ex);
            {
                Console.WriteLine(ex.ToString);
            }
            Console.WriteLine(evaluate.EvalAge(edad));
        }
    }
}
