using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4.clases
{
    internal class RRHH
    {
        //Calcular el salario neto de un empleado
        public RRHH() { }
        public CalcularSalario(Empleado empleado, double deducciones)
        {
            return empleado.Salary - deducciones;
        }

        //Aumentar el salario de un empleado en un 5% si su salario es menor a x salario
        public void AumentarSalario(Empleado empleado, double porcentaje, double techo)
        {
            empleado.Salary = (empleado.Salary <= techo) ? empleado.Salary = (empleado.Salary * (1 + porcentaje)) : empleado.Salary;
        }
        
    }
}
