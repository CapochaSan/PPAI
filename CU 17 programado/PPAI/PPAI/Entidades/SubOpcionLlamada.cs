using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PPAI.Entidades
{
    public class SubOpcionLlamada : IAgregado
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
            List<Object> elementos = validacionesRequeridas.OfType<Object>().ToList();
            IteradorValidacion iterador = crearIterador(elementos) as IteradorValidacion;
            iterador.primero();            
            while (!iterador.haTerminado())
            {
                Validacion validacion = iterador.actual() as Validacion;
                mensajesValidaciones.Add(validacion.getMensajeValidacion);
                iterador.siguiente();
            }
            return mensajesValidaciones;
            //foreach (Validacion validacion in validacionesRequeridas)
            //{
            //    mensajesValidaciones.Add(validacion.getMensajeValidacion);
            //}
            //return mensajesValidaciones;
        }

        public Iterador crearIterador(List<Object> elementos)
        {
            List<Validacion> listaValidaciones = elementos.OfType<Validacion>().ToList();
            IteradorValidacion iterador = new IteradorValidacion(listaValidaciones);
            return iterador;
        }
    }
}
