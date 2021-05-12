using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CarritoCompra
    {
        //definir atributos
        private DateTime fechaCreacion;
        private string nroProductos;
        private string precioTotal;

        //propiedades
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string NroProductos { get => nroProductos; set => nroProductos = value; }
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }

        //metodos
        public string GuardarProductos()
        {
            return "El metodo Guardar Productos no esta implementado";
        }

        public string VerProductosDeInteres()
        {
            return "El metodo Ver Productos de Interes no ha sido implementado";
        }
    }
}
