using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Company
    {

        public int IDCompany { get; set; }
        public string CedulaJ { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public DataTable ListarForCombo()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPCompanyListarCb");

            return R;
        }
        public DataTable Listar(string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.DMLSelect("SPCompanyListar");

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@CedulaJ", this.CedulaJ));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            if (!string.IsNullOrEmpty(this.Email))
            {
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));

            }
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDCompany));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPCompanyEditar");

            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

        public Company ConsultarPorID(int ID)
        {
            Company R = new Company();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPCompanyConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDCompany = ID;
                R.CedulaJ = Convert.ToString(Fila["CedulaJ"]);
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.Email = Convert.ToString(Fila["Email"]);
                R.Telefono = Convert.ToString(Fila["Telefono"]);
                R.Direccion = Convert.ToString(Fila["Direccion"]);
            }
            return R;
        }

        public bool ConsultarPorCedula(string cedula)
        {
            bool R = false;
            Conexion MiConexion = new Conexion();
            // En este caso y de forma didactica se decidio implementar un parametro para la cedula
            // este valor debe agregarse como parametro que debe llegar hasta el SP
            MiConexion.ListadoDeParametros.Add(new SqlParameter("@CedulaJ", cedula));

            DataTable retorno = MiConexion.DMLSelect("SPCompanyConsultarPorCedula");

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
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@CedulaJ", this.CedulaJ));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            if (this.Email != null)
            {
                MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));
            }
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));

            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPCompanyAgregar");
            // 1.6.5
            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

    }
}
