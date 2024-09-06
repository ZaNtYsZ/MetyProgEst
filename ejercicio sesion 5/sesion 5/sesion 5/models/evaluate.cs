using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion_5.models
{
    internal class evaluate
    {
        public evaluate() { }

        public string EvalAge(int age)
        {
            try
            { 
              if (age >= 0 && age <= 12) return "Eres un nino;";
              else if (age >= 13 && age <= 25) return "Eres un joven;";
              else if (age >= 26 && age <= 120) return "Eres un adulto ";
            } cath (Exception ex)
            {
                return $"Error {ex.ToString}";
            }
            return "Edad no valida ";
        }
    }
}
