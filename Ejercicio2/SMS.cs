namespace EjerciciosDIP.Ejercicio2
{
    public class SMS :INotificacion
    {
        public string Numero { get; set; }
        public string Mensaje { get; set; }

        public void Enviar()
        {
            
        }

        public void enviar()
        {
            throw new System.NotImplementedException();
        }
    }
}