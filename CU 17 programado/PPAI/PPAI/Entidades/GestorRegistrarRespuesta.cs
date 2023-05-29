using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private DateTime fechaHoraFinLlamada;
        private List<string> mensajesValidaciones;
        private string nombreCliente;
        private List<string> nombreCatOpcSub;
        private string fechaAValidar;
        private string cantHijos;
        private string datoAValidar1;
        private string datoAValidar2;
        public string descripcionOperador;
        public string accionARealizar;
        private PantallaRegistrarRespuesta pantalla;



        public GestorRegistrarRespuesta(HashSet<Estado> estados)
        {
            this.estados = estados;
            this.mensajesValidaciones = new List<string>();
        }
        public void nuevaRespuestaOperador(Llamada llamadaCliente, CategoriaLlamada catSeleccionada,OpcionLlamada opcSeleccionada, SubOpcionLlamada subOpcionSeleccionada, PantallaRegistrarRespuesta pantalla)
        {
            this.llamadaCliente = llamadaCliente;
            this.opcion = opcion;
            this.subOpcion = subOpcion;
            this.pantalla = pantalla;
            recibirLlamada(llamadaCliente);
            obtenerDatosLlamada(llamadaCliente, catSeleccionada, opcSeleccionada, subOpcionSeleccionada);
            mensajesValidaciones = buscarValidacionesDeSubOpcion(catSeleccionada, opcSeleccionada, subOpcionSeleccionada);
            pantalla.InitializeComponent();
            mostrarDatosLlamadas(catSeleccionada, opcSeleccionada, subOpcionSeleccionada, nombreCatOpcSub);
            pantalla.solicitarRespuestaAValidacion(mensajesValidaciones);
            
        }

        public void recibirLlamada(Llamada llamadaCliente)
        {
            llamadaCliente.tomadaPorOperador(buscarEstadoEnCursoParaAsignar(), getDateTime());
        }

        public Estado buscarEstadoEnCursoParaAsignar()
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

        public void mostrarDatosLlamadas(CategoriaLlamada catSeleccionada, OpcionLlamada opcSeleccionada, SubOpcionLlamada subOpcionSeleccionada, List<string> nombreCatSubOpc)
        {
            pantalla.mostrarDatosLlamadas(nombreCliente, nombreCatOpcSub);            
        }

        public bool tomarIngresoDatoValidacion(Cliente clienteLlamada, string respuesta, bool validado)
        {

            validado = validarInfoCliente(clienteLlamada, respuesta, validado);
            return validado;
            
        }
        public bool validarInfoCliente(Cliente clienteLlamada, string respuesta, bool validado)
        {
            validado = clienteLlamada.esInfoCorrecta(respuesta, validado);
            return validado;
        }

        public void eventoValidacionCorrecta()
        {
            pantalla.solicitarRespuesta();
        }
        public void tomarIngresoRta(string descripcion, string accion)
        {
            descripcionOperador = descripcion;
            accionARealizar = accion;
            pantalla.solicitarConfirmacion();
            
        }
        public void tomarConfirmacion()
        {
            llamarCURegistrarAccionRequerida();
        }
        public void llamarCURegistrarAccionRequerida( )
        {
            //extend CU: Registrar Accion Requerida
            pantalla.mostrarAccionRegistrada();
            finalizarLlamada();
        }
        public void finalizarLlamada()
        {
            fechaHoraFinLlamada = getDateTime();
            buscarEstadoFinalizadaParaAsignar();
            llamadaCliente.finalizarLlamada(buscarEstadoFinalizadaParaAsignar(), getDateTime());
            finCU();
        }
        public Estado buscarEstadoFinalizadaParaAsignar()
        {
            foreach (Estado estado in estados)
            {
                if (estado.Finalizada())
                {
                    return estado;
                }
            }
            return null;
        }
        private void finCU()
        {
            pantalla.Close();
        }
    }

}
