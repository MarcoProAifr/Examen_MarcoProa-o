using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MarcoProaño
{
    public class ProfeH : ProfeI
    {

        public int PrecioHora { get; set; }
        public int HorasTrabajadas { get; set; }

        public string Sueldo()
        {

            int precioHora = 15, horasTrabajadas = 16, sueldo;

            sueldo = precioHora * horasTrabajadas;

            string mensaje = "Precio por hora: " + precioHora + "\nHoras trabajadas: " + horasTrabajadas + "\nSueldo_por_Hora: " + sueldo;

            return mensaje;

        }
    }
}
