using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UserRol
    {

        public int IDUserRol { get; set; }
        public string Descripcion { get; set; }
        public bool PAgregar { get; set; }
        public bool PEditar { get; set; }
        public bool PEliminar { get; set; }
        public bool PConsultar { get; set; }
        public bool PReport { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsAutorizador { get; set; }
        public bool POrdenCompra { get; set; }

        //ADDED
        public bool PChofer { get; set; }
        public bool PVehiculo { get; set; }
        public bool PMantenimiento { get; set; }
        public bool PGasto { get; set; }



        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPUserRolListar");

            return R;
        }



        public UserRol ConsultarPorID(int ID)
        {
            UserRol R = new UserRol();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPUsuarioRolConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {

                DataRow Fila = DatosUsuario.Rows[0];

                R.IDUserRol = ID;
                R.Descripcion = Convert.ToString(Fila["Descripcion"]);
                R.PAgregar = Convert.ToBoolean(Fila["PAgregar"]);
                R.PEditar = Convert.ToBoolean(Fila["PEditar"]);
                R.PEliminar = Convert.ToBoolean(Fila["PEliminar"]);
                R.PConsultar = Convert.ToBoolean(Fila["PConsultar"]);
                R.PReport = Convert.ToBoolean(Fila["PReport"]);
                R.IsAdmin = Convert.ToBoolean(Fila["IsAdmin"]);
                R.PChofer = Convert.ToBoolean(Fila["PChofer"]);
                R.PVehiculo = Convert.ToBoolean(Fila["PVehiculo"]);
                R.PMantenimiento = Convert.ToBoolean(Fila["PMantenimiento"]);
                R.PGasto = Convert.ToBoolean(Fila["PGasto"]);
                R.IsAutorizador = Convert.ToBoolean(Fila["IsAutorizador"]);
                R.POrdenCompra = Convert.ToBoolean(Fila["POrdenCompra"]);

            }

            return R;
        }


        public bool ConsultarPorDescripcion()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            DataTable resultado = MiCnn.DMLSelect("SPUserRolPorDescripcion");
            if (resultado != null && resultado.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnnAdd = new Conexion();

            // Agregar los parametros para el SP
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PAgregar", this.PAgregar));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PEditar", this.PEditar));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PEliminar", this.PEliminar));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PConsultar", this.PConsultar));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PReport", this.PReport));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IsAdmin", this.IsAdmin));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PChofer", this.PChofer));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PVehiculo", this.PVehiculo));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PMantenimiento", this.PMantenimiento));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@PGasto", this.PGasto));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IsAutorizador", this.IsAutorizador));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@POrdenCompra", this.POrdenCompra));
         
            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPUsuarioRolAgregar");
            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PAgregar", this.PAgregar));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PEditar", this.PEditar));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PEliminar", this.PEliminar));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PConsultar", this.PConsultar));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PReport", this.PReport));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IsAdmin", this.IsAdmin));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PChofer", this.PChofer));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PVehiculo", this.PVehiculo));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PMantenimiento", this.PMantenimiento));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@PGasto", this.PGasto));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IsAutorizador", this.IsAutorizador));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@POrdenCompra", this.POrdenCompra));

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDUserRol));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioRolEditar");
            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

    }
}
