namespace EjerciciosDIP.Ejercicio3
{
    public class Cliente : IPedidoCliente
    {
        public void CrearOrden()
        {
            Pagar();
        }

        public void Pagar(){}

        public void RecibirCafe(){}

        public void RecibirOrden()
            //private
        {
           RecibirCafe();  
        }
    }
}