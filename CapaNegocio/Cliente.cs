using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente : Identificacion
    {
        //Atributos
        private string direccion;
        private string teléfono;
        private string email;
        private string apellidos;
        private string nombres;

        //Propiedades
        public string Direccion { get => direccion; set => direccion = value; }
        public string Teléfono { get => teléfono; set => teléfono = value; }
        public string Email { get => email; set => email = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }

        //Métodos
        public string ComprarProducto()
        {
            return "Metodo no implementado";
        }
        public string PagarProducto()
        {
            return "Metodo no implementado";
        }
        public string UsarProducto()
        {
            return "Metodo no implementado";
        }
    }
}
