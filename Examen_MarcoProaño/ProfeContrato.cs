using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MarcoProaño
{
    public class ProfeContrato : ProfeI
    {

        public int SueldoBasico { get; set; }
        public int Horas_Extras { get; set; }

        public string Sueldo()
        {

            int sueldoBasico = 450, horasExtra = 4, sueldo;

            sueldo = sueldoBasico + horasExtra;

            string datos = "Sueldo básico: " + sueldoBasico + "\nHoras extra: " + horasExtra + "\nSueldo: " + sueldo;


            return datos;
        }
    }
}