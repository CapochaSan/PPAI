using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class IteradorValidacion : Iterador
    {
        private List<Validacion> elementos;
        private int posicionActual;
        private List<Validacion> filtros;

        public IteradorValidacion(List<Validacion> elementos)
        {

            this.elementos = elementos;
        }

        public void setFiltros(List<Validacion> filtros) { this.filtros = filtros; }

        public object actual()
        {
            if (elementos[posicionActual] != null)
            {
                return elementos[posicionActual];
            }
            else { return null; }
            
            
        }

        public bool cumpleFiltro(List<object> filtros)
        {
            throw new NotImplementedException();
        }

        public bool haTerminado()
        {
            // Verificar si posicionActual está dentro de los límites de la matriz
            if (posicionActual >= 0 && posicionActual < elementos.Count)
            {
                // Verificar si el elemento en la posición actual es nulo
                if (elementos[posicionActual] == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // La posición actual está fuera de los límites de la matriz
                return true;
            }
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual ++;
        }
    }
}
