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
        private string nombre;

        public Validacion(string MensajeValidacion, string nombre)
        {
            this.MensajeValidacion = MensajeValidacion;
            this.nombre = nombre;
        }
        public string getMensajeValidacion
        {
            get => MensajeValidacion;
        }
    }
}
