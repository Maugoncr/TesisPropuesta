using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoMantenimiento
    {

        public int IDTipoMantenimiento { get; set; }
        public string Detalle { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPTipoMantenimientoListar");

            return R;
        }

        public TipoMantenimiento ConsultarPorID(int ID)
        {
            TipoMantenimiento R = new TipoMantenimiento();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPTipoMantenimientoConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDTipoMantenimiento = ID;
                R.Detalle = Convert.ToString(Fila["Detalle"]);
            }
            return R;
        }

        public bool ConsultarPorDescripcion()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Detalle", this.Detalle));
            DataTable resultado = MiCnn.DMLSelect("SPTipoMantenimientoPorDetalle");
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
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Detalle", this.Detalle));

            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPTipoMantenimientoAgregar");
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

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Detalle", this.Detalle));

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDTipoMantenimiento));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPTipoMantenimientoEditar");
            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }


    }
}
