using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public interface Iterador
    {
        Object actual();
        void siguiente();
        void primero();
        Boolean haTerminado();
        Boolean cumpleFiltro(List<Object> filtros);

    }
}
