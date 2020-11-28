using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            return string.Format("se agrego a la lista: {0}", value);
        }
        //ejemplo1.1
        public double convertirDolares(double pesos)
        {
            return pesos * 20.52;
        }
        //metodo 3
        
        
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public Alumnos GetDatosAlumnos(Alumnos alumnos)
        {
            return alumnos;
        }

        public Alumnos CrearAlumnos()
        {
            
           Alumnos alumno = new Alumnos();
            alumno.Nombre = "jimbo mendieta";
            alumno.NoControl = 1235466;
            alumno.Semestre = 9;
            alumno.Promedio = 100;
       
            return alumno;

        }

        public Libros GetDatosLibros(Libros libros)
        {
            return libros;
        }

        public Libros CrearLibrosos()
        {
            Libros libros = new Libros();
            libros.Autor = "Tim Burton";
            libros.Titulo ="Sombras tenebrosas";
            libros.Año = 2009;
            libros.Id = 100;
            return libros;
        }

        public Producto GetProducto(Producto producto)
        {

            return producto;

        }

        public Producto GetIdProducto()
        {
            Producto producto = new Producto();
            producto.Nombre = "jabon de baño";
            producto.Id = 19;
            producto.Precio = 10;
            return producto;

        }
    }
}
