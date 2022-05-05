namespace EjerciciosDIP.Ejercicio3
{
    public class EntregaDomicilio
    {
        private IPedidoCliente _cliente;
        private IVentaCafeteria _cafeteria;

        public EntregaDomicilio()
        {
            _cliente = new Cliente();
            _cafeteria = new Cafeteria();
        }

        public void EntregarDomicilio()
        {
            _cliente.CrearOrden();
            _cafeteria.Despachadora();
            _cliente.RecibirOrden();
            //_cafeteria.ObtenerPago();
            //_cafeteria.DespacharCafe();
            //_cliente.RecibirCafe();
        }
    }
}