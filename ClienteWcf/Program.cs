using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteWcf
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePeliculas.Service1Client cliente = new ServicePeliculas.Service1Client();
            var alumno = cliente.CrearAlumnos();
            var lista = cliente.GetDatosAlumnos(alumno);
            Console.WriteLine(lista.Nombre);
        }
    }
}
