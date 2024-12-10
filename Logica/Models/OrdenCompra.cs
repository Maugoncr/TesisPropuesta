using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class OrdenCompra
    {
        public int IDOrdenCompra { get; set; }
        public string Codigo { get; set; }
        public string DetalleOrdenCompra { get; set; }
        public DateTime FechaParaRealizar { get; set; }
        public DateTime FechaCreacionOrden { get; set; }
        public DateTime FechaImpresion { get; set; }
        public DateTime FechaUtilizada { get; set; }
        public bool IsGasto { get; set; }
        public bool IsMantimiento { get; set; }
        public bool ActivoSinUsar { get; set; }
        public double Costo { get; set; }

        // fks
        public int IDChofer { get; set; }
        public int IDCarro { get; set; }
        public int IDUsuario { get; set; }
        public int IDCompany { get; set; }
        public int IDPlace { get; set; }
        public int IDArchivo { get; set; }
        public int IDArchivo2 { get; set; }

        //Composiciones

        public Chofer MiChoferOrden { get; set; }
        public Vehiculo MiVehiculoOrden { get; set; }
        public Usuario MiUsuarioOrden { get; set; }
        public Company MiCompanyOrden { get; set; }
        public Place MiPlaceOrden { get; set; }
        public Archivo MiArchivoOrden { get; set; }
        public Archivo MiArchivoOrden2 { get; set; }

        public OrdenCompra()
        {
            MiChoferOrden = new Chofer();
            MiVehiculoOrden = new Vehiculo();
            MiUsuarioOrden = new Usuario();
            MiCompanyOrden = new Company();
            MiPlaceOrden = new Place();
            MiArchivoOrden = new Archivo();  
            MiArchivoOrden2 = new Archivo();
        }

        public DataTable Listar(bool VerActivos, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPOrdenesCompraListarDataGrid");

            return R;
        }

        public DataTable ListarForSelectMantenimiento(string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPOrdenListarSelectMantenimiento");

            return R; 
        }

        public DataTable ListarForSelectGasto(string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPOrdenListarSelectGasto");

            return R;
        }


        public bool Agregar()
        {
            bool R = false;
            Conexion MiCnnAdd = new Conexion();

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Codigo", this.Codigo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@DetalleOrdenCompra", this.DetalleOrdenCompra));
            //Validar que sea una fecha mayor que ayer, puede ser hoy o cualquier dia futuro
            if (FechaParaRealizar != null && FechaParaRealizar > DateTime.Today.Date.AddDays(-1))
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FechaParaRealizar", this.FechaParaRealizar));
            }
            // FechaCreacionOrden es en la DB
            if (FechaImpresion != null && FechaImpresion > DateTime.Today.Date.AddDays(-1))
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FechaImpresion", this.FechaImpresion));
            }
            // Fecha Utilizada nunca se va poner en el agregar

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Costo", this.Costo));

            //FKs

            if (MiChoferOrden.IDChofer != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDChofer", this.MiChoferOrden.IDChofer));
            }
            if (MiVehiculoOrden.IDCarro != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCarro", this.MiVehiculoOrden.IDCarro));
            }
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDUsuario", this.MiUsuarioOrden.IDUser));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCompany", this.MiCompanyOrden.IDCompany));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDPlace", this.MiPlaceOrden.IDPlace));
            if (MiArchivoOrden.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDArchivo", this.MiArchivoOrden.IDImg));
            }
            if (MiArchivoOrden2.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDArchivo2", this.MiArchivoOrden2.IDImg));
            }
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IsGasto", this.IsGasto));
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IsMantenimiento", this.IsMantimiento));
            
            //Activo vendra por defecto siempre al agregarse

            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPOrdenCompraAgregar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

        public OrdenCompra ConsultarPorID(int ID)
        {
            OrdenCompra R = new OrdenCompra();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosOrdenCompra = new DataTable();

            DatosOrdenCompra = MiCnn.DMLSelect("SPOrdenCompraConsultarPorID");

            if (DatosOrdenCompra != null && DatosOrdenCompra.Rows.Count == 1)
            {
                DataRow Fila = DatosOrdenCompra.Rows[0];
                R.IDOrdenCompra = ID;
                R.Codigo = Convert.ToString(Fila["Codigo"]);
                R.DetalleOrdenCompra = Convert.ToString(Fila["DetalleOrdenCompra"]);
                R.Costo = Convert.ToDouble(Fila["Costo"]);
                R.FechaParaRealizar = Convert.ToDateTime(Fila["FechaParaRealizar"]);
                R.MiUsuarioOrden.IDUser = Convert.ToInt32(Fila["IDUsuario"]);
                R.MiPlaceOrden.IDPlace = Convert.ToInt32(Fila["IDPlace"]);
                R.MiCompanyOrden.IDCompany = Convert.ToInt32(Fila["IDCompany"]);
                R.IsGasto = Convert.ToBoolean(Fila["IsGasto"]);
                R.IsMantimiento = Convert.ToBoolean(Fila["IsMantenimiento"]);

                //Posibles nulls
                
                if (Fila["IDArchivo"] != DBNull.Value)
                {
                    R.MiArchivoOrden.IDImg = Convert.ToInt32(Fila["IDArchivo"]);
                }
                if (Fila["IDArchivo2"] != DBNull.Value)
                {
                    R.MiArchivoOrden2.IDImg = Convert.ToInt32(Fila["IDArchivo2"]);
                }
                if (Fila["Placa"] != DBNull.Value)
                {
                    R.MiVehiculoOrden.Placa = Convert.ToString(Fila["Placa"]);
                }
                if (Fila["FullName"] != DBNull.Value)
                {
                    R.MiChoferOrden.FullName = Convert.ToString(Fila["FullName"]);
                }
                if (Fila["IDCarro"] != DBNull.Value)
                {
                    R.MiVehiculoOrden.IDCarro = Convert.ToInt32(Fila["IDCarro"]);
                }
                if (Fila["IDChofer"] != DBNull.Value)
                {
                    R.MiChoferOrden.IDChofer = Convert.ToInt32(Fila["IDChofer"]);
                }
            }
            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnnAdd = new Conexion();

            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Codigo", this.Codigo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@DetalleOrdenCompra", this.DetalleOrdenCompra));
            //Validar que sea una fecha mayor que ayer, puede ser hoy o cualquier dia futuro
            
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FechaParaRealizar", this.FechaParaRealizar));
           
            // FechaCreacionOrden es en la DB
            // Fecha Utilizada nunca se va poner en el agregar
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            //FKs
            if (MiChoferOrden.IDChofer != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDChofer", this.MiChoferOrden.IDChofer));
            }
            if (MiVehiculoOrden.IDCarro != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCarro", this.MiVehiculoOrden.IDCarro));
            }
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDUsuario", this.MiUsuarioOrden.IDUser));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDCompany", this.MiCompanyOrden.IDCompany));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDPlace", this.MiPlaceOrden.IDPlace));
            if (MiArchivoOrden.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDArchivo", this.MiArchivoOrden.IDImg));
            }
            if (MiArchivoOrden2.IDImg != 0)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IDArchivo2", this.MiArchivoOrden2.IDImg));
            }
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IsGasto", this.IsGasto));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IsMantenimiento", this.IsMantimiento));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDOrdenCompra));

            int retorno = MiCnnAdd.DMLUpdateDeleteInsert("SPOrdenCompraEditar");

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
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDOrdenCompra));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPOrdenCompraEliminar");

            if (retorno == 1)
            {
                R = true;
            }


            return R;
        }
        public bool EliminarComoUsada(int ID)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPOrdenCompraEliminarUsada");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        public bool ImpresionMarcarFecha(int ID)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPOrdenCompraImpresion");

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
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDOrdenCompra));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPOrdenCompraActivar");

            if (retorno == 1)
            {
                R = true;
            }
            return R;

        }


    }
}
