using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class InformacionCliente
    {
        private string datoAValidar;
        private List<Validacion> validaciones;

        public InformacionCliente(string datoAValidar)
        {
            this.datoAValidar = datoAValidar;
        }

    }
}
