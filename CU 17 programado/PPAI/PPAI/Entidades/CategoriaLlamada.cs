using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CategoriaLlamada
    {
        private string mensajeOpciones;
        private string nombre;
        private int nroOrden;
        private List<OpcionLlamada> opcion;        
        private List<string> mensajesValidaciones;
        private List<string> nombreCatOpcSub;

        public CategoriaLlamada(string mensajeOpciones, string nombre, int nroOrden)
        {
            this.mensajeOpciones = mensajeOpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.opcion = new List<OpcionLlamada>();
            this.nombreCatOpcSub = new List<string>();
        }
        public List<string> getNombre(OpcionLlamada opcSeleccionada, SubOpcionLlamada subOpcionSeleccionada)
        {

            nombreCatOpcSub.Add(nombre);
            nombreCatOpcSub.Add(opcSeleccionada.getNombre(subOpcionSeleccionada)[0]);
            nombreCatOpcSub.Add(opcSeleccionada.getNombre(subOpcionSeleccionada)[1]);
            return nombreCatOpcSub;
        }

        public List<string> buscarValidacionesDeSubOpcion(OpcionLlamada opcSeleccionada, SubOpcionLlamada subOpcionSeleccionada)
        {
            mensajesValidaciones = new List<string> ();
            mensajesValidaciones = opcSeleccionada.buscarValidacionesDeSubOpcion(subOpcionSeleccionada);
            return mensajesValidaciones;
        }
    }
}
