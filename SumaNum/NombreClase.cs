using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    public class NombreClase
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int telefono;
        public string correo;

        public NombreClase(string nombre, string apellido, int edad, int telefono, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
