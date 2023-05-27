
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Estado
    {
        private string nombre;

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre
        {
            get => nombre;            
        }
        public bool EsEnCurso()
        {           
          if (nombre == "EnCurso")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
