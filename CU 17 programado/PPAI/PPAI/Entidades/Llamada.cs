using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private TimeSpan duracion;
        private string observacionAuditor;
        private Cliente cliente;
        private List<CambioEstado> cambioEstado;
        private CambioEstado cambioEstadoEnCursoLlamada;
        private CambioEstado cambioEstadoFinalizadaLlamada;

        public Llamada(string descripcionOperador, string detalleAccionRequerida, string observacionAuditor, Cliente cliente)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.observacionAuditor = observacionAuditor;
            this.cliente = cliente;
            cambioEstado = new List<CambioEstado>();
         }   


        public void tomadaPorOperador(Estado estado, DateTime fechaHora) 
        {
            cambioEstadoEnCursoLlamada = new CambioEstado(fechaHora, estado);
            cambioEstado.Add(cambioEstadoEnCursoLlamada);
        }
        
        public string getNombreClienteDeLlamada()
        {
            return cliente.getNombre();
        }   

        public void finalizarLlamada(Estado estado, DateTime fechaHora)
        {
            cambioEstadoFinalizadaLlamada = new CambioEstado(fechaHora, estado);
            cambioEstado.Add(cambioEstadoEnCursoLlamada);
            setDuracion(calcularDuracion());
        }
        public TimeSpan calcularDuracion()
        {
            TimeSpan duracion = cambioEstadoEnCursoLlamada.getFechaHoraInicio - cambioEstadoEnCursoLlamada.getFechaHoraFin;
            return duracion;
        }
        public void setDuracion(TimeSpan duracionLlamadaEnCurso)
        {
            this.duracion = duracionLlamadaEnCurso;
        }
    }
}
