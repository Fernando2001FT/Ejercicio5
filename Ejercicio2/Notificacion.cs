using System.Collections.Generic;

namespace EjerciciosDIP.Ejercicio2
{
    public class Notificacion
    {
        //private readonly Email _email;
        //private readonly SMS _sms;
        private readonly List<INotificacion> _notificaciones;
        private List<INotificacion> notificaciones;

        public Notificacion(List<INotificacion> _notificaciones)
        {
            //_email = email;
            //_sms = sms;
            _notificaciones = notificaciones;
        }

        public void Enviar()
        {
            //_email.EnviarSMS();
            //_sms.EnviarSMS();
            foreach (var notificacion in _notificaciones )
            {
                notificacion.Enviar();
            }
        }
    }
}