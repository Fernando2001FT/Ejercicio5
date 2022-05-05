using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDIP.Ejercicio3
{
    public class Cliente1 : IPedidoCliente
    {
        public void CrearOrden()
        {
            Pagar();
        }

        private void Pagar() { }

        private void RecibirCafe() { }

        public void RecibirOrden()
        //private codigo 2 que esta puesto private 
        {
            RecibirCafe();
        }
    }
}