using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class SubOpcionLlamada
    {
        private string nombre;
        private int nroOrden;
        private List<Validacion> validacionesRequeridas;
        private List<string> mensajesValidaciones;

        public SubOpcionLlamada(string nombre, int nroOrden, List<Validacion> validacionesRequerida)
        {
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.mensajesValidaciones = new List<string>();
            validacionesRequeridas = validacionesRequerida;
        }
        
        public string getNombre
        {
            get => nombre;
        }
        //public List<byte[]> buscarValidacionesDeSubOpcion(SubOpcionLlamada subOpcionSeleccionada)
        //{
        //    foreach (Validacion validacion in subOpcionSeleccionada.validacionesRequeridas)
        //    {
        //        subOpcionSeleccionada.mensajesValidaciones.Add(validacion.getMensajeValidacion);
        //    }
        //    return mensajesValidaciones;
        //}
        public List<string> buscarValidacionesDeSubOpcion()
        {
            foreach (Validacion validacion in validacionesRequeridas)
            {
                mensajesValidaciones.Add(validacion.getMensajeValidacion);
            }
            return mensajesValidaciones;
        }
    }
}
