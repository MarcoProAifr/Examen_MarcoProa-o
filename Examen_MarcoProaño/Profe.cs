using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MarcoProaño
{
    public class Profe
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int Cedula { get; set; }
        public string MostrarDatos(string nombres, string apellidos, string direccion, int cedula)
        {string datos = "Nombres: " + nombres + "\nApellidos: " + apellidos + "\nDirección: " + direccion + "\nCédula: " + cedula + "\n";
            return datos; }
    }
}