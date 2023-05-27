using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class GestorRegistrarRespuesta
    {
        private HashSet<Estado> estados;
        public Estado buscarEstadoParaAsignar()
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
    }
}
