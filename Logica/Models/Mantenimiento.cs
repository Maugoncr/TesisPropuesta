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
    public class Mantenimiento
    {
        public int IDMantenimiento { get; set; }
        public string Consecutivo { get; set; }
        public int IDOrdenCompra { get; set; }
        public double Costo { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public double Litro { get; set; }
        public int Kilometraje { get; set; }
        public int Recorrido { get; set; }
        public double CostoKm { get; set; }
        public double CostoLitro { get; set; }
        public string Detalles { get; set; }
        public DateTime DateRTV { get; set; }
        public DateTime OilDate { get; set; }
        public int Marchamo { get; set; }

        public string TipoCarro { get; set; }


        // FK's
        public int IDPlace { get; set; }
        public int IDCarro { get; set; }
        public int IDChofer { get; set; }
        public int IDTipoMantenimiento { get; set; }
        public int IDCompany { get; set; }
        public int IDArchivo { get; set; }
        public int IDArchivo2 { get; set; }

        // Composiciones
        public Place MiPlaceDelMantenimiento { get; set; }
        public Archivo MiArchivoDelMantenimiento { get; set; }
        public Archivo MiArchivo2DelMantenimiento { get; set; }
        public Company MiCompanyDelMantenimiento { get; set; }
        public Chofer MiChoferDelMantenimiento { get; set; }
        public Vehiculo MiVehiculoDelMantenimiento { get; set; }
        public TipoMantenimiento MiTipoMantenimientoDelMantenimiento { get; set; }

        public OrdenCompra MiOrdenCompraDelMantenimiento { get; set; }

        public Mantenimiento()
        {
            MiPlaceDelMantenimiento = new Place();
            MiArchivoDelMantenimiento = new Archivo();
            MiArchivo2DelMantenimiento = new Archivo();
            MiCompanyDelMantenimiento = new Company();
            MiChoferDelMantenimiento = new Chofer();
            MiVehiculoDelMantenimiento = new Vehiculo();
            MiTipoMantenimientoDelMantenimiento = new TipoMantenimiento();
            MiOrdenCompraDelMantenimiento = new OrdenCompra();
        }

        public DataTable Listar(string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPMantenimientoListarDataGrid");

            return R;
        }

        public bool Agregar()
        {
            bool R = false;
            Conexion MiCnnAdd = new Conexion();

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Consecutivo", this.Consecutivo));
           
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDOrdenCompra", this.MiOrdenCompraDelMantenimiento.IDOrdenCompra));
            
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDPlace", this.MiPlaceDelMantenimiento.IDPlace));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCarro", this.MiVehiculoDelMantenimiento.IDCarro));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDChofer", this.MiChoferDelMantenimiento.IDChofer));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDTipoMantenimiento", this.MiTipoMantenimientoDelMantenimiento.IDTipoMantenimiento));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCompany", this.MiCompanyDelMantenimiento.IDCompany));

            if (MiArchivoDelMantenimiento.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDImg", this.MiArchivoDelMantenimiento.IDImg));
            }
            if (MiArchivo2DelMantenimiento.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDImg2", this.MiArchivo2DelMantenimiento.IDImg));
            }

           // MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FechaRegistro", this.FechaRegistro));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FechaMantenimiento", this.FechaMantenimiento));

            if (Litro != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Litro", this.Litro));
            }

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Kilometraje", this.Kilometraje));

            if (Recorrido != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Recorrido", this.Recorrido));
            }
            if (CostoKm != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@CostoKm", this.CostoKm));
            }
            if (CostoLitro != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@CostoLitro", this.CostoLitro));
            }
            if (Detalles != null && Detalles != "")
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Detalles", this.Detalles));
            }
            if (DateRTV != null && DateRTV > DateTime.Today.Date)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@DateRTV", this.DateRTV));
            }
            if (Marchamo != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Marchamo", this.Marchamo));
            }
            if (OilDate != null && OilDate > DateTime.Today.Date)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@OilDate", this.OilDate));
            }

            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPMantenimientoAgregar");
            if (DateRTV != null && DateRTV > DateTime.Today.Date)
            {
                EditarRTVVehiculo();
            }
            if (Marchamo != 0)
            {
                EditarMarchamoVehiculo();
            }
            if (OilDate != null && OilDate > DateTime.Today.Date)
            {
                EditarOilDateVehiculo();
            }

            bool resultado2 = EditarKilometrajeVehiculo();
            if (resultado > 0 && resultado2)
            {
                R = true;
            }
            return R;
        }

        private bool EditarKilometrajeVehiculo()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Kilometraje", this.Kilometraje));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.MiVehiculoDelMantenimiento.IDCarro));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPVehiculoActualizarKm");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        private bool EditarRTVVehiculo()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@RTV", this.DateRTV));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.MiVehiculoDelMantenimiento.IDCarro));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPVehiculoActualizarRTV");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        private bool EditarOilDateVehiculo()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@OilDate", this.OilDate));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.MiVehiculoDelMantenimiento.IDCarro));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPVehiculoActualizarOilChange");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        private bool EditarMarchamoVehiculo()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Marchamo", this.Marchamo));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.MiVehiculoDelMantenimiento.IDCarro));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPVehiculoActualizarMarchamo");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        public void SeleccionarChoferM(int ID)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            R = MiCnn.DMLSelect("SPChoferSelectNameByID");

            DataRow Fila = R.Rows[0];

            MiChoferDelMantenimiento.FullName = Convert.ToString(Fila["FullName"]);

        }

        public void SeleccionarVehiculoM(int ID)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            R = MiCnn.DMLSelect("SPVehiculoSelectForM");

            DataRow Fila = R.Rows[0];

            MiVehiculoDelMantenimiento.Placa = Convert.ToString(Fila["Placa"]);
            MiVehiculoDelMantenimiento.Kilometraje = Convert.ToInt32(Fila["Kilometraje"]);
            TipoCarro = Convert.ToString(Fila["Descripcion"]);

        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnnAdd = new Conexion();

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Consecutivo", this.Consecutivo));
            
           
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDOrdenCompra", this.MiOrdenCompraDelMantenimiento.IDOrdenCompra));
            
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDPlace", this.MiPlaceDelMantenimiento.IDPlace));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCarro", this.MiVehiculoDelMantenimiento.IDCarro));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDChofer", this.MiChoferDelMantenimiento.IDChofer));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDTipoMantenimiento", this.MiTipoMantenimientoDelMantenimiento.IDTipoMantenimiento));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCompany", this.MiCompanyDelMantenimiento.IDCompany));

            if (MiArchivoDelMantenimiento.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDImg", this.MiArchivoDelMantenimiento.IDImg));
            }
            if (MiArchivo2DelMantenimiento.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDImg2", this.MiArchivo2DelMantenimiento.IDImg));
            }

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FechaMantenimiento", this.FechaMantenimiento));

            if (Litro != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Litro", this.Litro));
            }

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Kilometraje", this.Kilometraje));

            if (Recorrido != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Recorrido", this.Recorrido));
            }
            if (CostoKm != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@CostoKm", this.CostoKm));
            }
            if (CostoLitro != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@CostoLitro", this.CostoLitro));
            }
            if (Detalles != null && Detalles != "")
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Detalles", this.Detalles));
            }
            if (DateRTV != null && DateRTV > DateTime.Today.Date)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@DateRTV", this.DateRTV));
            }
            if (Marchamo != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Marchamo", this.Marchamo));
            }
            if (OilDate != null && OilDate > DateTime.Today.Date)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@OilDate", this.OilDate));
            }
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDMantenimiento));

            int retorno = MiCnnAdd.DMLUpdateDeleteInsert("SPMantenimientoEditar");

            if (DateRTV != null && DateRTV > DateTime.Today.Date)
            {
                EditarRTVVehiculo();
            }
            if (Marchamo != 0)
            {
                EditarMarchamoVehiculo();
            }
            if (OilDate != null && OilDate > DateTime.Today.Date)
            {
                EditarOilDateVehiculo();
            }
            bool resultado2 = EditarKilometrajeVehiculo();

           

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }


        public Mantenimiento ConsultarPorID(int ID)
        {
            Mantenimiento R = new Mantenimiento();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosMantenimiento = new DataTable();

            DatosMantenimiento = MiCnn.DMLSelect("SPMantenimientoConsultarPorID");

            if (DatosMantenimiento != null && DatosMantenimiento.Rows.Count == 1)
            {
                DataRow Fila = DatosMantenimiento.Rows[0];
                R.IDMantenimiento = ID;
                R.Consecutivo = Convert.ToString(Fila["Consecutivo"]);
                
              
                
                R.Costo = Convert.ToDouble(Fila["Costo"]);

                //Composiciones
                R.MiPlaceDelMantenimiento.IDPlace = Convert.ToInt32(Fila["IDPlace"]);
                R.MiVehiculoDelMantenimiento.IDCarro = Convert.ToInt32(Fila["IDCarro"]);
                R.MiChoferDelMantenimiento.IDChofer = Convert.ToInt32(Fila["IDChofer"]);
                R.MiTipoMantenimientoDelMantenimiento.IDTipoMantenimiento = Convert.ToInt32(Fila["IDTipoMantenimiento"]);
                R.MiCompanyDelMantenimiento.IDCompany = Convert.ToInt32(Fila["IDCompany"]);
                R.MiOrdenCompraDelMantenimiento.IDOrdenCompra = Convert.ToInt32(Fila["IDOrdenCompra"]);
                if (Fila["IDArchivo"] != DBNull.Value)
                {
                    R.MiArchivoDelMantenimiento.IDImg = Convert.ToInt32(Fila["IDArchivo"]);
                }
                if (Fila["IDArchivo2"] != DBNull.Value)
                {
                    R.MiArchivo2DelMantenimiento.IDImg = Convert.ToInt32(Fila["IDArchivo2"]);
                }
                if (Fila["FechaRegistro"] != DBNull.Value)
                {
                    R.FechaRegistro = Convert.ToDateTime(Fila["FechaRegistro"]);
                }
                R.FechaMantenimiento = Convert.ToDateTime(Fila["FechaMantenimiento"]);
                if (Fila["FechaModificacion"] != DBNull.Value)
                {
                    R.FechaModificacion = Convert.ToDateTime(Fila["FechaModificacion"]);
                }
                if (Fila["Litro"] != DBNull.Value)
                {
                    R.Litro = Convert.ToDouble(Fila["Litro"]);
                }
                if (Fila["Kilometraje"] != DBNull.Value)
                {
                    R.Kilometraje = Convert.ToInt32(Fila["Kilometraje"]);
                }
                if (Fila["Recorrido"] != DBNull.Value)
                {
                    R.Recorrido = Convert.ToInt32(Fila["Recorrido"]);
                }
                if (Fila["CostoKm"] != DBNull.Value)
                {
                    R.CostoKm = Convert.ToDouble(Fila["CostoKm"]);
                }
                if (Fila["CostoLitro"] != DBNull.Value)
                {
                    R.CostoLitro = Convert.ToDouble(Fila["CostoLitro"]);
                }
                if (Fila["Detalles"] != DBNull.Value)
                {
                    R.Detalles = Convert.ToString(Fila["Detalles"]);
                }
                if (Fila["DateRTV"] != DBNull.Value)
                {
                    R.DateRTV = Convert.ToDateTime(Fila["DateRTV"]);
                }
                if (Fila["Marchamo"] != DBNull.Value)
                {
                    R.Marchamo = Convert.ToInt32(Fila["Marchamo"]);
                }
                if (Fila["OilDate"] != DBNull.Value)
                {
                    R.OilDate = Convert.ToDateTime(Fila["OilDate"]);
                }

            }
            return R;
        }

        public Mantenimiento TraerInfoOrdenCompra(int ID)
        {
            Mantenimiento R = new Mantenimiento();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosMantenimiento = new DataTable();

            DatosMantenimiento = MiCnn.DMLSelect("SPOrdenCompraInfoMantenimientoConsultarPorID");

            if (DatosMantenimiento != null && DatosMantenimiento.Rows.Count == 1)
            {
                DataRow Fila = DatosMantenimiento.Rows[0];

                R.MiOrdenCompraDelMantenimiento.IDOrdenCompra = ID;

                if (Fila["IDArchivo"] != DBNull.Value)
                {
                    R.MiArchivoDelMantenimiento.IDImg = Convert.ToInt32(Fila["IDArchivo"]);
                }
                if (Fila["IDArchivo2"] != DBNull.Value)
                {
                    R.MiArchivo2DelMantenimiento.IDImg = Convert.ToInt32(Fila["IDArchivo2"]);
                }
                if (Fila["IDCarro"] != DBNull.Value)
                {
                    R.MiVehiculoDelMantenimiento.IDCarro = Convert.ToInt32(Fila["IDCarro"]);
                    R.MiVehiculoDelMantenimiento.Kilometraje = Convert.ToInt32(Fila["Kilometraje"]);
                    R.MiVehiculoDelMantenimiento.Placa = Convert.ToString(Fila["Placa"]);
                    R.TipoCarro = Convert.ToString(Fila["Descripcion"]);
                }
                if (Fila["IDChofer"] != DBNull.Value)
                {
                    R.MiChoferDelMantenimiento.IDChofer = Convert.ToInt32(Fila["IDChofer"]);
                    R.MiChoferDelMantenimiento.FullName = Convert.ToString(Fila["FullName"]);
                }

                R.MiCompanyDelMantenimiento.IDCompany = Convert.ToInt32(Fila["IDCompany"]);
                R.MiPlaceDelMantenimiento.IDPlace = Convert.ToInt32(Fila["IDPlace"]);

                R.Costo = Convert.ToInt32(Fila["Costo"]);

                R.FechaMantenimiento = Convert.ToDateTime(Fila["FechaParaRealizar"]);

                R.Detalles = Convert.ToString(Fila["DetalleOrdenCompra"]);

              

            }
            return R;
        }

        // REPORTES

        public DataTable ReporteMantenimientoConFechasYCompany(DateTime desde, DateTime hasta, int IDCompany)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Company", IDCompany));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));

            R = MiCnn.DMLSelect("SPMantenimientoReporteConFechaCompany");

            return R;
        }

        public ReportDocument ImprimirReporteMantenimientoConFechasYCompany(DateTime desde, DateTime hasta, int IDCompany, ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Company", IDCompany));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));

            Datos = MiCnn.DMLSelect("SPMantenimientoReporteConFechaCompany");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public DataTable ReporteMantenimientoConFechasSinCompany(DateTime desde, DateTime hasta)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));

            R = MiCnn.DMLSelect("SPMantenimientoReporteConFechaSinCompany");

            return R;
        }

        public ReportDocument ImprimirReporteMantenimientoConFechasSinCompany(DateTime desde, DateTime hasta, ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));

            Datos = MiCnn.DMLSelect("SPMantenimientoReporteConFechaSinCompany");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public DataTable ReporteMantenimientoSinFechaConCompany(int IDCompany)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Company", IDCompany));

            R = MiCnn.DMLSelect("SPMantenimientoReporteSinFechaConCompany");

            return R;
        }

        public ReportDocument ImprimirReporteMantenimientoSinFechaConCompany(int IDCompany, ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Company", IDCompany));

            Datos = MiCnn.DMLSelect("SPMantenimientoReporteSinFechaConCompany");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public DataTable ReporteMantenimientoGeneral()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPMantenimientoReporteGeneral");

            return R;
        }

        public ReportDocument ImprimirReporteMantenimientoGeneral(ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            Datos = MiCnn.DMLSelect("SPMantenimientoReporteGeneral");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }


    }
}
