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
        private int nroCelular;
        
        public Cliente(int dni, string nombre, int nroCel)
        {
            this.dni = dni;
            this.nombreCompleto = nombre;
            this.nroCelular = nroCel;
        }
        public string getNombre
        {
            get => nombreCompleto;
        }
    }
}
