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
        private Validacion validacion;
        private TipoInformacion tipoInformacion;
        public InformacionCliente(string datoAValidar, TipoInformacion tipoInformacion)
        {
            this.datoAValidar = datoAValidar;
            this.tipoInformacion = tipoInformacion;
        }
        public void setValidacion(Validacion validacion)
        {
            this.validacion = validacion;
        }

        public bool esInformacionCorrecta(string respuesta)
        {
            if (respuesta == datoAValidar)
            {
                
                return true;
            }
            else { return false; }
            
        }
        public bool esValidacion(Validacion val)
        {
            if (val == validacion)
            {

                return true;
            }
            else { return false; }

        }
        public String toString()
        {
            return datoAValidar + " " + validacion.getMensajeValidacion + " ";
        }

    }
}
