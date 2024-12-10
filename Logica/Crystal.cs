using CrystalDecisions.CrystalReports.Engine;
using System.Data;


namespace Logica
{
    public class Crystal
    {
        //Esto tomará la forma del reporte que necesitemos
        public ReportDocument Reporte { get; set; }

        //contiene la data que se visuliza en el reporte
        public DataTable Datos { get; set; }

        public Crystal(ReportDocument pRpt)
        {
            Reporte = pRpt;
        }

        public Crystal()
        {

        }

        public ReportDocument GenerarReporte()
        {
            if (Datos.Rows.Count > 0)
            {
                Reporte.SetDataSource(Datos);

                return Reporte;
            }
            else
            { return null; }
        }

    }
}
