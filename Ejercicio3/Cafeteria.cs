namespace EjerciciosDIP.Ejercicio3
{
    public class Cafeteria: IVentaCafeteria
    {
        private void ObtenerPago(){}
        private void DespacharCafe(){}
        private void CalienteAgua() { }

        public void Despachadora()
        {
            ObtenerPago();
            DespacharCafe();
            CalienteAgua();
        }
        //private void CalienteAgua();
    }
}