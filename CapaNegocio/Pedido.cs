using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pedido : Identificacion 
    {
        //Atributos
        private DateTime fechaRealizacion;
        private int total;
        private string estado;

        //Propiedades
        public DateTime FechaRealizacion { get => fechaRealizacion; set => fechaRealizacion = value; }
        public int Total { get => total; set => total = value; }
        public string Estado { get => estado; set => estado = value; }

        //Métodos
        public string LlevarProducto()
        {
            return "Metodo no implementado";
        }
        public string CuidarProducto()
        {
            return "Metodo no implementado";
        }
    }
}
