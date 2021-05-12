using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Envio : Identificacion 
    {
        //Atributos
        private string direccionFacturacion;
        private string finalizado;
        private DateTime fechaEnvio;
        private string compania;

        //Propiedades
        public string DireccionFacturacion { get => direccionFacturacion; set => direccionFacturacion = value; }
        public string Finalizado { get => finalizado; set => finalizado = value; }
        public DateTime FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public string Compania { get => compania; set => compania = value; }

        //Métodos
        public string MandarProducto()
        {
            return "Metodo no implementado";
        }
        public string EmpacarProducto()
        {
            return "Metodo no implementado";
        }
    }
}
