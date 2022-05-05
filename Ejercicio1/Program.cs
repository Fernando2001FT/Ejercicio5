namespace EjerciciosDIP.Ejercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var importadorReporteDB = new ImportadorReporteBDD();
            var presentadorReporte = new PresentadorReporte(importadorReporteDB);
            presentadorReporte.MostrarReporte();

            var importadorReporteExel = new ImportadorReporteBDD();
            presentadorReporte = new PresentadorReporte(importadorReporteExel);
            presentadorReporte.MostrarReporte();
        }
    }
}