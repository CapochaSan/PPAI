using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class OpcionLlamada
    {
        private string mensajeSubpciones;
        private string nombre;
        private int nroOrden;
        private SubOpcionLlamada subOpcionLlamada;
        private List<string> datosLlamada;
        private List<Validacion> validacionesRequeridas;
        private List<string> mensajesValidaciones;

        public OpcionLlamada(string mensajeSubpciones, string nombre, int nroOrden)
        {
            this.mensajeSubpciones = mensajeSubpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            validacionesRequeridas = new List<Validacion>();
            datosLlamada = new List<string>();

        }

        public List<string> getNombre(SubOpcionLlamada subOpcionSeleccionada)
        {   
            datosLlamada.Add(nombre);
            datosLlamada.Add(subOpcionSeleccionada.getNombre);            
            return datosLlamada;
        }
        public List<string> buscarValidacionesDeSubOpcion(SubOpcionLlamada subOpcionSeleccionada)
        {
            mensajesValidaciones = new List<string>();
            mensajesValidaciones = subOpcionSeleccionada.buscarValidacionesDeSubOpcion();
            return mensajesValidaciones;
        }
    }
}
