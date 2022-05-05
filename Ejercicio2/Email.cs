namespace EjerciciosDIP.Ejercicio2
{
    public class Email: INotificacion
    {
        public string Direccion { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }

        public void Enviar()
        {
            
        }

        public void enviar()
        {
            throw new System.NotImplementedException();
        }
    }
}