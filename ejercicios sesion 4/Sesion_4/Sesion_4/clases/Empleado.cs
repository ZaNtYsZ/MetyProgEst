using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4.clases
{
    //Calcular el salario neto de un empleado 
    internal class Empleado
    {
        public Empleado() { }

        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public double Phone { get; set; }
        public double Salary { get; set; }

        public Empleado(int iD, string firstname, string lastname, string email, double phone, double salary)
        {
            ID = iD;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phone = phone;
            Salary = salary;
        }
    }
}
