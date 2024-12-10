using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Vehiculo
    {
        public int IDCarro { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Anio { get; set; }
        public DateTime RTV { get; set; }
        public int Marchamo { get; set; }
        public DateTime OilDate { get; set; }
        public DateTime LicenciaCamionesVencimiento { get; set; }
        public int Kilometraje { get; set; }
        public int IDTipo { get; set; }
        public int IDChofer { get; set; }
        public int IDCompany { get; set; }
        public bool Activo { get; set; }

        // Composiciones

        public TipoVehiculo MiTipo { get; set; }

        public Chofer MiChofer { get; set; }

        public Company MiCompany { get; set; }

        public Vehiculo()
        {
            MiTipo = new TipoVehiculo();
            MiChofer = new Chofer();
            MiCompany = new Company();
        }

        public DataTable Listar(bool VerActivos, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPVehiculosListar");

            return R;
        }

        public DataTable ReporteVehiculoAll(int company)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDCompany", company));

            R = MiCnn.DMLSelect("SPVehiculoReporteAll");

            return R;
        }

        public ReportDocument ImprimirReporteVehiculoAll(int company, ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDCompany", company));

            Datos = MiCnn.DMLSelect("SPVehiculoReporteAll");

            if (Datos != null &&  Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public DataTable ReporteVehiculoPorPlaca(string placa)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Placa", placa));

            R = MiCnn.DMLSelect("SPReporteVehiculoPorPlaca");

            return R;
        }

        public ReportDocument ImprimirReporteVehiculoPorPlaca(string placa, ReportDocument reporte)
        {
            ReportDocument R = reporte;

            Crystal OCrystal = new Crystal(R);

            DataTable Datos = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Placa", placa));

            Datos = MiCnn.DMLSelect("SPReporteVehiculoPorPlaca");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                OCrystal.Datos = Datos;
                R = OCrystal.GenerarReporte();
            }

            return R;
        }

        public DataTable ListarForSelect(string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPVehiculoListarSelect");

            return R;
        }
        public DataTable ListarRTV1Mes()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPVehiculosListarRTV1Mes");

            return R;
        }
        public DataTable ListarOil1Mes()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPVehiculosListarAceite1Mes");

            return R;
        }

        public DataTable ListarRTVVencidos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPVehiculosListarRTVVencidos");

            return R;
        }

        public DataTable ListarOilVencidos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPVehiculosListarAceitesVencidos");

            return R;
        }

        public DataTable ListarRTVs(int num = 0)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Num", num));

            R = MiCnn.DMLSelect("SPVehiculosListarRTV");

            return R;
        }

        public DataTable ListarOil(int num = 0)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Num", num));

            R = MiCnn.DMLSelect("SPVehiculosListarOil");

            return R;
        }
        
        public DataTable ListarOilConFiltro(string filtro, int num = 0)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Num", num));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", filtro));

            R = MiCnn.DMLSelect("SPVehiculosListarOilConFiltro");

            return R;
        }

        public DataTable ListarRTVConFiltro(string filtro, int num = 0)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Num", num));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", filtro));

            R = MiCnn.DMLSelect("SPVehiculosListarRTVConFiltro");

            return R;
        }

        public DataTable ListarMarchamos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPVehiculosListarMarchamos");

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Placa", this.Placa));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Marca", this.Marca));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@OilDate", this.OilDate));
            if (LicenciaCamionesVencimiento > DateTime.Today.Date)
            {
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@LicenciaCamionesVencimiento", this.LicenciaCamionesVencimiento));
            }
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@RTV", this.RTV));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Marchamo", this.Marchamo));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Anio", this.Anio));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDTipo", this.MiTipo.IDTipo));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDChofer", this.MiChofer.IDChofer));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDCompany", this.MiCompany.IDCompany));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDCarro));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Kilometraje", this.Kilometraje));


            int retorno = MiCnn.DMLUpdateDeleteInsert("SPVehiculoEditar");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDCarro));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPVehiculoEliminar");

            if (retorno == 1)
            {
                R = true;
            }


            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDCarro));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPVehiculoActivar");

            if (retorno == 1)
            {
                R = true;
            }
            return R;

        }

        public Vehiculo ConsultarPorID(int ID)
        {
            Vehiculo R = new Vehiculo();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPVehiculoConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDCarro = ID;
                R.Placa = Convert.ToString(Fila["Placa"]);
                R.Marca = Convert.ToString(Fila["Marca"]);
                R.Anio = Convert.ToString(Fila["Anio"]);
               ///
                R.OilDate = Convert.ToDateTime(Fila["OilDate"]);
                if (Fila["LicenciaCamionesVencimiento"] != DBNull.Value)
                {
                    R.LicenciaCamionesVencimiento = Convert.ToDateTime(Fila["LicenciaCamionesVencimiento"]);
                }
                R.Marchamo = Convert.ToInt32(Fila["Marchamo"]);
                R.Kilometraje = Convert.ToInt32(Fila["Kilometraje"]);
                R.RTV = Convert.ToDateTime(Fila["RTV"]);

                //Composiciones
                R.MiCompany.IDCompany = Convert.ToInt32(Fila["IDCompany"]);
                R.MiTipo.IDTipo = Convert.ToInt32(Fila["IDTipo"]);
                R.MiChofer.IDChofer = Convert.ToInt32(Fila["IDChofer"]);
            }
            return R;
        }


        public bool ConsultarPorPlaca(string placa)
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
            // En este caso y de forma didactica se decidio implementar un parametro para la cedula
            // este valor debe agregarse como parametro que debe llegar hasta el SP
            MiConexion.ListadoDeParametros.Add(new SqlParameter("@Placa", placa));

            DataTable retorno = MiConexion.DMLSelect("SPVehiculoConsultarPorPlaca");

            if (retorno != null && retorno.Rows.Count > 0)
            {
                R = true;
            }
            return R;

        }   
        public bool ConsultarHayCambiosOil()
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
            DataTable retorno = MiConexion.DMLSelect("SPVehiculoHayCambiosProx");

            if (retorno != null && retorno.Rows.Count > 0)
            {
                R = true;
            }
            return R;

        }

        public bool ConsultarHayCambiosOilVencidos()
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
            DataTable retorno = MiConexion.DMLSelect("SPVehiculoHayCambiosVencidos");

            if (retorno != null && retorno.Rows.Count > 0)
            {
                R = true;
            }
            return R;

        }

        public bool ConsultarRTVEsteMes()
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
            DataTable retorno = MiConexion.DMLSelect("SPVehiculoHayRTVProx");

            if (retorno != null && retorno.Rows.Count > 0)
            {
                R = true;
            }
            return R;
           
        }

        public bool ConsultarRTVVencido()
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
            DataTable retorno = MiConexion.DMLSelect("SPVehiculoHayRTVVencido");

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
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Placa", this.Placa));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Marca", this.Marca));
            ///
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@OilDate", this.OilDate));
          
            if (LicenciaCamionesVencimiento > DateTime.Today.Date)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@LicenciaCamionesVencimiento", this.LicenciaCamionesVencimiento));
            }
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@RTV", this.RTV));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Marchamo", this.Marchamo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Anio", this.Anio));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDTipo", this.MiTipo.IDTipo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDChofer", this.MiChofer.IDChofer));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCompany", this.MiCompany.IDCompany));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Kilometraje", this.Kilometraje));

            
            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPVehiculoAgregar");
            // 1.6.5
            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }



    }
}
