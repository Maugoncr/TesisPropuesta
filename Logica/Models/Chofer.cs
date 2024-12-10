using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Chofer
    {
        public int IDChofer { get; set; }
        public string FullName { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string CodigoEmpleado { get; set; }
        public bool Activo { get; set; }


        public DataTable Listar(bool VerActivos, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPChoferListar");

            return R;
        }

     

        public DataTable ListarForSelect(string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPChoferListarSelect");

            return R;
        }

        public DataTable ListarForCombo()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPChoferesListarCb");

            return R;
        }


        public Chofer ConsultarPorID(int ID)
        {
            Chofer R = new Chofer();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPChoferConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDChofer = ID;
                R.FullName = Convert.ToString(Fila["FullName"]);
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.Telefono = Convert.ToString(Fila["Telefono"]);
                R.Email = Convert.ToString(Fila["Email"]);
                R.CodigoEmpleado = Convert.ToString(Fila["CodigoEmpleado"]);
            }
            return R;
        }

        public bool ConsultarPorCedula(string cedula)
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
           
            MiConexion.ListadoDeParametros.Add(new SqlParameter("@Cedula", cedula));

            DataTable retorno = MiConexion.DMLSelect("SPChoferConsultarPorCedula");

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
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@FullName", this.FullName));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@CodigoEmpleado", this.CodigoEmpleado));
            // 1.6.3 y 1.6.4
            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPChoferAgregar");
            // 1.6.5
            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }
        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDChofer));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPChoferEliminar");

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
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDChofer));
            int retorno = MiCnn.DMLUpdateDeleteInsert("SPChoferActivar");
            if (retorno == 1)
            {
                R = true;
            }
            return R;

        }
        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.FullName));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@CodigoEmpleado", this.CodigoEmpleado));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDChofer));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPChoferEditar");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }


    }
}
