using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoArchivo
    {
        public int IDTipoArchivo { get; set; }

        public string DescripcionTipoArchivo { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPTipoArchivoListar");

            return R;
        }

        public TipoArchivo ConsultarPorID(int ID)
        {
            TipoArchivo R = new TipoArchivo();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPTipoArchivoConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];
                R.IDTipoArchivo = ID;
                R.DescripcionTipoArchivo = Convert.ToString(Fila["DescripcionTipoArchivo"]);
            }
            return R;
        }

        public bool ConsultarPorDescripcion()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@DescripcionTipoArchivo", this.DescripcionTipoArchivo));
            DataTable resultado = MiCnn.DMLSelect("SPTipoArchivoPorDetalle");
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
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@DescripcionTipoArchivo", this.DescripcionTipoArchivo));

            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPTipoArchivoAgregar");
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

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@DescripcionTipoArchivo", this.DescripcionTipoArchivo));

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID", this.IDTipoArchivo));

            int retorno = MiCnn.DMLUpdateDeleteInsert("SPTipoArchivoEditar");
            if (retorno == 1)
            {
                R = true;
            }
            return R;
        }


    }
}
