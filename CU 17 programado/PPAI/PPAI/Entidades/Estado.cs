﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Estado
    {
        private string Name;

        public Estado(string nombre)
        {
            this.Name = nombre;
        }
        public string NombreEstado
        {
            get => Name;            
        }
    }
}