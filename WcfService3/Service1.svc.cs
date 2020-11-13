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
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        //ejemplo1.1
        public double convertirDolares(double pesos)
        {
            return pesos * 20.52;
        }
        //metodo 3
        Libro libro = new Libro();
        public string GetIdBiblioteca(int value)
        {
            if (value == 1)
            {
                libro.Titulo = "Matematicas";
                return string.Format("El libro es:" + libro.Titulo);
            }
            else if (value == 2)
            {
                libro.Titulo = "Español";
                return string.Format("El libro es:" + libro.Titulo);
            }
            else if (value == 3)
            {
                libro.Titulo = "Ciencias";
                return string.Format("El libro es:" + libro.Titulo);
            }
            else if (value == 4)
            {
                libro.Titulo = "Historia";
                return string.Format("El libro es:" + libro.Titulo);
            }

            return null;

        }
        //metodo 2
        Producto producto = new Producto();
        public string GetIdProducto(int value)
        {
            if(value == 12)
            {
                producto.Nombre = "Coca-Cola";
                return string.Format("su producto es" + producto.Nombre);
            }
            else if (value == 678)
            {
                producto.Nombre = "Jugo";
                return string.Format("su producto es" + producto.Nombre);
            }

            else if (value == 34)
            {
                producto.Nombre = "Manzanita";
                return string.Format("su producto es" + producto.Nombre);

            }
            return null;
        }
        
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
        public Libro GetLibro(Libro libro)
        {
            return libro;
        }
        public Producto GetProducto(Producto producto)
        {
            return producto;
        }

        public Alumnos GetDatosAlumnos(Alumnos alumnos)
        {
            return alumnos;
        }

        public Alumnos CrearAlumnos()
        {
            
            Alumnos alumno = new Alumnos();
            alumno.Nombre = "Lizeth Mendieta";
            alumno.NoControl = 17030094;
            alumno.Semestre = 6;
            alumno.Promedio = 79;
       
            return alumno;

        }
    }
   
}
