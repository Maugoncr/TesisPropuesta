using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoVehiculo
    {

        public int IDTipo { get; set; }
        public string Descripcion { get; set; }

        public TipoVehiculo ConsultarPorID(int ID)
        {
            TipoVehiculo R = new TipoVehiculo();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPTiposVehiculoConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDTipo = ID;
                R.Descripcion = Convert.ToString(Fila["Descripcion"]);
            }
            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPTiposVehiculoListar");

            return R;
        }

        public bool ConsultarPorDescripcion()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            DataTable resultado = MiCnn.DMLSelect("SPTiposVehiculoPorDescripcion");
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

            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPTipoVehiculoAgregar");
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

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDTipo));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPTipoVehiculoEditar");
            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }

    }
}
