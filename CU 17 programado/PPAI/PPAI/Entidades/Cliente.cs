using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Cliente : IAgregado
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
        public bool esInfoCorrecta(string respuesta, bool validado, Validacion validacion)
        {
            List<Object> elementos = info.OfType<Object>().ToList();
            IteradorInformacionCliente iterador = crearIterador(elementos) as IteradorInformacionCliente;
            
            List<Object> filtros = new List<object>();
            filtros.Add(validacion as object);
            filtros.Add(respuesta as object);

            iterador.setFiltros(filtros);

            iterador.primero();
            while (!iterador.haTerminado())
            {
                InformacionCliente infoCliente = iterador.actual() as InformacionCliente;
                
                if (iterador.getValidado()) 
                {
                    validado = iterador.getValidado();                    
                    break;
                }

                iterador.siguiente();
            }
            return validado;


            //foreach (InformacionCliente infoCliente in info)
            //{
            //    if ((infoCliente.esInformacionCorrecta(respuesta)) && infoCliente.esValidacion(validacion))
            //    {
            //        //(infoCliente.esInformacionCorrecta(respuesta)) &&
            //        validado = (infoCliente.esInformacionCorrecta(respuesta)) && infoCliente.esValidacion(validacion);

            //        break;
            //    }
            //}
            //return validado;
        }

        public Iterador crearIterador(List<object> elementos)
        {
            IteradorInformacionCliente iterador = new IteradorInformacionCliente(elementos);
            return iterador;
        }
        public int getDNI()
        {
            return dni;
        }
    }
}
