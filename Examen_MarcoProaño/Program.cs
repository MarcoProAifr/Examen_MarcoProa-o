using System;
using System.Collections.Generic;

namespace Examen_MarcoProaño
{
    class Program
    {
        static void Main(string[] args)
        {

            Profe profe1 = new Profe();
            profe1.Nombres = "Juan Marco";
            profe1.Apellidos = "Proaño Chele";
            profe1.Direccion = "Las Cumbres";
            profe1.Cedula = 1315645752;

            Console.WriteLine(profe1.MostrarDatos(profe1.Nombres, profe1.Apellidos, profe1.Direccion, profe1.Cedula));

            ProfeH profe2 = new ProfeH();

            ProfeContrato profe3 = new ProfeContrato();

            ProfeNombramiento profe4 = new ProfeNombramiento();

            List<ProfeI> lista = new List<ProfeI>();

            lista.Add(profe2); lista.Add(profe3); lista.Add(profe4);

            for (int i = 0; i < lista.Count; i++)
            {  var data = lista[i];
                Console.WriteLine(data.Sueldo() + "\n");  }

        }
    }
}