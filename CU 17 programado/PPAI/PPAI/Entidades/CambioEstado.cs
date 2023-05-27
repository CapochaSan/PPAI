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
        private Estado estado;

        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            fechaHoraInicio = fechaHoraInicio;
            estado = estado;
        }
        public DateTime getFechaHoraInicio
        {
            get => fechaHoraInicio;
        }
        public Estado getNombreEstado
        {
            get => estado;
        }
    }
}
