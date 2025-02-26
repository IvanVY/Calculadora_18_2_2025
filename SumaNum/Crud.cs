using Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNum
{
    public class Crud
    {
        public List<NombreClase> lista = new List<NombreClase>();

        public void agregarObjeto(NombreClase p)
        {
            
            lista.Add(p);
        }
    }
}
