using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CambioEstado
    {
        public DateTime FechaHoraInicio {set; get; }
        public DateTime FechaHoraFin { set; get; }
        public Estado Estado { set; get; }

        public CambioEstado(DateTime fechaHoraInicio, DateTime fechaHoraFin, Estado estado)
        {
            FechaHoraInicio = fechaHoraInicio;
            FechaHoraFin = fechaHoraFin;
            Estado = estado;
        }
       
    }
}
