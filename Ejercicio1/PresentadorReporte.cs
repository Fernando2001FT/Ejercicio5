using System;

namespace EjerciciosDIP.Ejercicio1
{
    public class PresentadorReporte: IReporteExel
    {
        private readonly IImportadordeDatos Importador;

        public PresentadorReporte(IImportadordeDatos importador)
        {
            Importador = importador;
        }

        public void ImportadorReporteExel()
        {
            throw new NotImplementedException();
        }

        public void MostrarReporte()
        {
            Console.WriteLine(Importador.ObtenerDatosReporte());
        }
    }
}