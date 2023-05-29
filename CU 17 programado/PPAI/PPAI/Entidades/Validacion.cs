using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Validacion
    {
        private string MensajeValidacion;
        private TipoInformacion tipo;

        public Validacion(string MensajeValidacion, TipoInformacion tipo)
        {
            this.MensajeValidacion = MensajeValidacion;
            this.tipo = tipo;
        }
        public string getMensajeValidacion
        {
            get => MensajeValidacion;
        }
    }
}
