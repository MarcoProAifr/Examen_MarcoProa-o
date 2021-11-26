using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MarcoProaño
{
    public class ProfeNombramiento : ProfeI
    {

        public int SueldoFijo { get; set; }

        public string Sueldo()
        {


            int sueldoFijo = 3300;

            string datos = "Profesor por nombramiento\n SueldoFijo: " + sueldoFijo;

            return datos;
        }
    }
}
