using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pago : Identificacion
    {
        //Atributos
        private DateTime fechaPago;
        private int monto;
        private string modoPago;

        //Propiedades
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public int Monto { get => monto; set => monto = value; }
        public string ModoPago { get => modoPago; set => modoPago = value; }

        //Métodos
        public string RecibirDinero()
        {
            return "Metodo no implementado";
        }
        public string ContarDinero()
        {
            return "Metodo no implementado";
        }
    }
}
