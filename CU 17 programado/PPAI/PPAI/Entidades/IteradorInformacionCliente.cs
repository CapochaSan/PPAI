using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace PPAI.Entidades
{
    internal class IteradorInformacionCliente : Iterador
    {
        private List<object> elementos;
        private int posicionActual;
        private List<object> filtros;
        private bool validado = false;

        public IteradorInformacionCliente(List<object> elementos)
        {
            this.elementos = elementos;
        }

        public bool getValidado() { return validado; }
        public void setFiltros(List<object> filtros) {  this.filtros = filtros;}

        public object actual()
        {
            if (elementos[posicionActual] != null)
            {
                validado = cumpleFiltro(filtros);
                return elementos[posicionActual];
            }
            else { return null; }
        }

        public bool cumpleFiltro(List<object> filtros)
        {
            InformacionCliente infoCliente = elementos[posicionActual] as InformacionCliente;
            Validacion val = filtros[0] as Validacion;
            String res = filtros[1] as String;

            if ((infoCliente.esInformacionCorrecta(res)) && infoCliente.esValidacion(val))
            {
                validado = (infoCliente.esInformacionCorrecta(res)) && infoCliente.esValidacion(val);
            }

            return validado;
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
