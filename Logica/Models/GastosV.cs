using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class GastosV
    {
        public int IDGasto { get; set; }
        public string Consecutivo { get; set; }
        public string Descrip { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public int IDOrdenCompra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaGasto { get; set; }
        public int IDPlace { get; set; }
        public int IDImg { get; set; }
        public int IDImg2 { get; set; }

        public int IDCompany { get; set; }

        // Composiciones

        public Place MiPlace { get; set; }
        public Archivo MiArchivo { get; set; }
        public Archivo MiArchivo2 { get; set; }

        public Company MiCompany { get; set; }

        public OrdenCompra MiOrden { get; set; }

        public GastosV()
        {
            MiPlace = new Place();
            MiArchivo = new Archivo();
            MiArchivo2 = new Archivo();
            MiCompany = new Company();
            MiOrden = new OrdenCompra();
        }


        public DataTable Listar( string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPGastosVariadosListar");

            return R;
        }

        public DataTable ReporteGastoConFechasYCompany(DateTime desde, DateTime hasta, int IDCompany)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Company", IDCompany));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));

            R = MiCnn.DMLSelect("SPGastoVReporteConFechaCompany");

            return R;
        }

        public ReportDocument ImprimirReporteGastoConFechasYCompany(DateTime desde, DateTime hasta, int IDCompany, ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Company", IDCompany));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));

            Datos = MiCnn.DMLSelect("SPGastoVReporteConFechaCompany");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public DataTable ReporteGastoConFechasSinCompany(DateTime desde, DateTime hasta)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));

            R = MiCnn.DMLSelect("SPGastoVReporteConFechaSinCompany");

            return R;
        }

        public ReportDocument ImprimirReporteGastoConFechasSinCompany(DateTime desde, DateTime hasta, ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));

            Datos = MiCnn.DMLSelect("SPGastoVReporteConFechaSinCompany");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public DataTable ReporteGastoSinFechaConCompany(int IDCompany)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Company", IDCompany));

            R = MiCnn.DMLSelect("SPGastoVReporteSinFechaConCompany");

            return R;
        }

        public ReportDocument ImprimirReporteGastoSinFechaConCompany(int IDCompany, ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Company", IDCompany));

            Datos = MiCnn.DMLSelect("SPGastoVReporteSinFechaConCompany");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public ReportDocument ImprimirReporteGastoGeneral(ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            Datos = MiCnn.DMLSelect("SPGastoVReporteGeneral");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public DataTable ReporteGastoGeneral()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPGastoVReporteGeneral");

            return R;
        }



        public GastosV ConsultarPorID(int ID)
        {
            GastosV R = new GastosV();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPGastoConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDGasto = ID;
                R.Consecutivo = Convert.ToString(Fila["Consecutivo"]);
                R.Descrip = Convert.ToString(Fila["Descrip"]);
                R.Cantidad = Convert.ToDouble(Fila["Cantidad"]);
                R.Costo = Convert.ToDouble(Fila["Costo"]);
                if ((Fila["FechaGasto"] != DBNull.Value))
                {
                    R.FechaGasto = Convert.ToDateTime(Fila["FechaGasto"]);
                }
                //Composiciones
                R.MiPlace.IDPlace = Convert.ToInt32(Fila["IDPlace"]);
                R.MiCompany.IDCompany = Convert.ToInt32(Fila["IDCompany"]);
               
                R.MiOrden.IDOrdenCompra = Convert.ToInt32(Fila["IDOrdenCompra"]);
                
                if (Fila["IDImg"]!= DBNull.Value)
                {
                    R.MiArchivo.IDImg = Convert.ToInt32(Fila["IDImg"]);
                }
                if (Fila["IDImg2"] != DBNull.Value)
                {
                    R.MiArchivo2.IDImg = Convert.ToInt32(Fila["IDImg2"]);
                }
                

            }
            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Consecutivo", this.Consecutivo));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Descrip", this.Descrip));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaGasto", this.FechaGasto));
           
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDOrdenCompra", this.MiOrden.IDOrdenCompra));
            

            if (MiArchivo.IDImg != 0)
            {
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDImg", this.MiArchivo.IDImg));
            }
            if (MiArchivo2.IDImg != 0)
            {
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDImg2", this.MiArchivo2.IDImg));
            }
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDPlace", this.MiPlace.IDPlace));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDCompany", this.MiCompany.IDCompany));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDGasto));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPGastoEditar");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        public bool ConsultarPorConsecutivo(string consecutivo)
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
            // En este caso y de forma didactica se decidio implementar un parametro para la cedula
            // este valor debe agregarse como parametro que debe llegar hasta el SP
            MiConexion.ListadoDeParametros.Add(new SqlParameter("@Consecutivo", consecutivo));

            DataTable retorno = MiConexion.DMLSelect("SPGastoConsultarPorConsecutivo");

            if (retorno != null && retorno.Rows.Count > 0)
            {
                R = true;
            }
            return R;

        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnnAdd = new Conexion();
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Consecutivo", this.Consecutivo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Descrip", this.Descrip));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FechaGasto", this.FechaGasto));
            
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDOrdenCompra", this.MiOrden.IDOrdenCompra));
            

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDPlace", this.MiPlace.IDPlace)); 
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCompany", this.MiCompany.IDCompany)); 

            if (MiArchivo.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDImg", this.MiArchivo.IDImg));
            }
            if (MiArchivo2.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDImg2", this.MiArchivo2.IDImg));
            }
            


            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPGastoVariadoAgregar");
            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

        public GastosV TraerInfoOrdenCompra(int ID)
        {
            GastosV R = new GastosV();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosMantenimiento = new DataTable();

            DatosMantenimiento = MiCnn.DMLSelect("SPOrdenCompraInfoGastoVConsultarPorID");

            if (DatosMantenimiento != null && DatosMantenimiento.Rows.Count == 1)
            {
                DataRow Fila = DatosMantenimiento.Rows[0];

                R.MiOrden.IDOrdenCompra = ID;

                if (Fila["IDArchivo"] != DBNull.Value)
                {
                    R.MiArchivo.IDImg = Convert.ToInt32(Fila["IDArchivo"]);
                }
                if (Fila["IDArchivo2"] != DBNull.Value)
                {
                    R.MiArchivo2.IDImg = Convert.ToInt32(Fila["IDArchivo2"]);
                }

                R.MiCompany.IDCompany = Convert.ToInt32(Fila["IDCompany"]);
                R.MiPlace.IDPlace = Convert.ToInt32(Fila["IDPlace"]);

                R.Costo = Convert.ToInt32(Fila["Costo"]);

                R.FechaGasto = Convert.ToDateTime(Fila["FechaParaRealizar"]);

                R.Descrip = Convert.ToString(Fila["DetalleOrdenCompra"]);



            }
            return R;
        }


    }
}
