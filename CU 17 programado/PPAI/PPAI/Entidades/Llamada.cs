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
        private int duracion;
        private string observacionAuditor;
        private Cliente cliente;
        private List<CambioEstado> cambioEstado;

        public Llamada(string descripcionOperador, string detalleAccionRequerida, int duracion, string observacionAuditor)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.observacionAuditor = observacionAuditor;
        }   


        public CambioEstado tomadaPorOperador(Estado estado, DateTime fechaHora) 
        {
            return new CambioEstado(fechaHora, estado);
        }
        
        public string getNombreClienteDeLlamada()
        {
            return cliente.getNombre;
        }
    }
}
