using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class GestorRegistrarRespuesta
    {
        private HashSet<Estado> estados;
        private Llamada llamadaCliente;
        private OpcionLlamada opcion;
        private SubOpcionLlamada subOpcion;
        private Cliente cliente;    
        private DateTime fechaHoraActual;
        private List<string> mensajesValidaciones;
        private string nombreCliente;
        private List<string> nombreCatOpcSub;
        private string fechaAValidar;
        private string cantHijos;



        public GestorRegistrarRespuesta(HashSet<Estado> estados)
        {
            this.estados = estados;
            this.mensajesValidaciones = new List<string>();
        }
        public void nuevaRespuestaOperador(Llamada llamadaCliente, CategoriaLlamada catSeleccionada,OpcionLlamada opcion, SubOpcionLlamada subOpcion)
        {
            this.llamadaCliente = llamadaCliente;
            this.opcion = opcion;
            this.subOpcion = subOpcion;
            recibirLlamada(llamadaCliente);
            obtenerDatosLlamada(llamadaCliente, catSeleccionada, opcion, subOpcion);
            
        }

        public void recibirLlamada(Llamada llamadaCliente)
        {
            llamadaCliente.tomadaPorOperador(buscarEstadoParaAsignar(), getDateTime());
        }

        public Estado buscarEstadoParaAsignar()
        {
            foreach (Estado estado in estados)
            {
                if (estado.EsEnCurso())
                {
                    return estado;
                }
            }
            return null;
        }
        public DateTime getDateTime()
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual;
        }

        public void obtenerDatosLlamada(Llamada llamadaCliente, CategoriaLlamada catSeleccionada,OpcionLlamada opcSeleccionada ,SubOpcionLlamada subOpcionSeleccionada)
        {
      
            nombreCliente = llamadaCliente.getNombreClienteDeLlamada();
            nombreCatOpcSub = catSeleccionada.getNombre(opcSeleccionada,subOpcionSeleccionada);
        }


        public List<string> buscarValidacionesDeSubOpcion(CategoriaLlamada catSeleccionada,OpcionLlamada opcSeleccionada, SubOpcionLlamada subOpcionSeleccionada)
        {
            mensajesValidaciones = new List<string> ();
            mensajesValidaciones = catSeleccionada.buscarValidacionesDeSubOpcion(opcSeleccionada,subOpcionSeleccionada);
            return mensajesValidaciones;
        }

        public void mostrarDatosLlamadas(PantallaRegistrarRespuesta pantalla, CategoriaLlamada catSeleccionada, OpcionLlamada opcSeleccionada, SubOpcionLlamada subOpcionSeleccionada)
        {
            //mensajesValidaciones = buscarValidacionesDeSubOpcion(catSeleccionada, opcSeleccionada, subOpcionSeleccionada);
            pantalla.mostrarDatosLlamadas(this, EventArgs.Empty);
            pantalla.solicitarRespuestaAValidacion();
        }

        public void tomarIngresoDatoValidacion(string fechaAValidar, string cantHijos)
        {
            this.fechaAValidar = fechaAValidar;
            this.cantHijos = cantHijos;
        }

        public void tomarIngresoDatoValidacion()
        {

        }

        public void validarInfoCliente(Cliente clienteLlamada)
        {

        }

    }

}
