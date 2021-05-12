using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto : Identificacion 
    {
        //Atributos
        private string denominacion;
        private string proveedor;

        //Propiedades
        public string Denominacion { get => denominacion; set => denominacion = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }

        //Métodos
        public string LlegarCliente()
        {
            return "Metodo no implementado";
        }
        public string SatisfacerCliente()
        {
            return "Metodo no implementado";
        }
    }
}
