using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private long nroCelular;
        private List<InformacionCliente> info;
        
        public Cliente(int dni, string nombre, long nroCel, List<InformacionCliente> info)
        {
            this.dni = dni;
            this.nombreCompleto = nombre;
            this.nroCelular = nroCel;
            this.info = info;
        }
        public string getNombre()
        {
            return nombreCompleto;
        }
        public bool esInfoCorrecta(string respuesta, bool validado)
        {
            foreach(InformacionCliente infoCliente in info)
            {
                if (infoCliente.esInformacionCorrecta(respuesta))
                {
                    validado = infoCliente.esInformacionCorrecta(respuesta);
                    break;
                }
            } return validado;
        }
        
    }
}
