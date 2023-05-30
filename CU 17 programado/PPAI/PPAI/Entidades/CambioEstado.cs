using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PPAI.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private Estado estado;

        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }
        public DateTime getFechaHoraInicio()
        {
            return fechaHoraInicio;
        }
        public DateTime getFechaHoraFin()
        {
            return fechaHoraFin;
        }
        public void setFechaHoraFin(DateTime fechaHoraFin)
        {
            this.fechaHoraFin = fechaHoraFin;
        }
    }
}
