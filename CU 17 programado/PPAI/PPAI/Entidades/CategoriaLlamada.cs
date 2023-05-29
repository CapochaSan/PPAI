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
        private List<string> datosLlamada;
        private List<string> mensajesValidaciones;

        public CategoriaLlamada(string mensajeOpciones, string nombre, int nroOrden)
        {
            this.mensajeOpciones = mensajeOpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.opcion = new List<OpcionLlamada>();
        }
        public List<string> getNombre(OpcionLlamada opcSeleccionada, SubOpcionLlamada subOpcionSeleccionada)
        {
            datosLlamada = opcSeleccionada.getNombre(subOpcionSeleccionada);
            datosLlamada.Add(this.nombre);
            return datosLlamada;
        }

        public List<string> buscarValidacionesDeSubOpcion(OpcionLlamada opcSeleccionada, SubOpcionLlamada subOpcionSeleccionada)
        {
            mensajesValidaciones = new List<string> ();
            mensajesValidaciones = opcSeleccionada.buscarValidacionesDeSubOpcion(subOpcionSeleccionada);
            return mensajesValidaciones;
        }
    }
}
