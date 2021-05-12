using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class LineaProducto
    {
        //atributos
        private string hambitoUso;
        private string nombre;
        private string precio;
        private int cantidad;

        public string HambitoUso { get => hambitoUso; set => hambitoUso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        //Metodos
        public string GuardarArticulos()
        {
            return "No se ha sido implementado el metodo Guardar Articulos";
        }

        public string ContactarProveedor()
        {
            return "No se ha sido implementado el metodo Contactar Porveedor";
        }
    }
}
