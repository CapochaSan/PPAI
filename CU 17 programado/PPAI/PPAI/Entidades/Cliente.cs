using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Cliente
    {
        private int Dni;
        private string Name;
        private int NroCel;
        
        public Cliente(int dni, string nombre, int nroCel)
        {
            this.Dni = dni;
            this.Name = nombre;
            this.NroCel = nroCel;
        }
        public string NombreCliente
        {
            get => Name;
            set => Name = value;

        }
        public int Doc
        {
            get => Dni;
            set => Dni = value;
        }
        public int NroCelCliente
        {
            get => NroCelCliente;
            set => NroCelCliente = value;
        }
    }
}
