using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class OpcionLlamada
    {
        private byte[] audioMensajeSubopciones;
        private string mensajeSubpciones;
        private string nombre;
        private int nroOrden;
        private SubOpcionLlamada subOpcionLlamada;
        private List<string> datosLlamada;
        private List<Validacion> validacionesRequeridas;
        private List<string> mensajesValidaciones;

        public OpcionLlamada(byte[] audioMensajeSubopciones, string mensajeSubpciones, string nombre, int nroOrden)
        {
            this.audioMensajeSubopciones = audioMensajeSubopciones;
            this.mensajeSubpciones = mensajeSubpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            validacionesRequeridas = new List<Validacion>();
            
    }

        public List<string> getNombre(SubOpcionLlamada subOpcionSeleccionada)
        {   datosLlamada = new List<string>();
            datosLlamada.Add(this.nombre);
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
