using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Llamada
    {
        public CambioEstado tomadaPorOperador(Estado estado, DateTime fechaHora) 
        {
            return new CambioEstado(fechaHora, estado);
        }
        
    }
}
