using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Bitacora
    {
        public int IDBitacora { get; set; }
        public int IDUser { get; set; }
        public string UserName { get; set; }
        public string Accion { get; set; }


        public void GuardarAccionBitacora(string Accion, int IDUsuario = 0, string FullName = "")
        {

            // verificar si es accion que trae el Usuario o no.

            if (IDUsuario != 0 && !string.IsNullOrEmpty(Accion) && !string.IsNullOrEmpty(FullName))
            {
                // si entra aqui hay id y hay accion
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Accion", Accion));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDUser", IDUsuario));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@UserName", FullName));

                int resultado = MiCnn.DMLUpdateDeleteInsert("SPGuardarAccionBitacora");

                if (resultado > 0)
                {
                    // si entra aqui significa que se agrego correctamente
                    // aunque claro esto no se deberia decir al usuario esto solo queda para mi prueba de funcionamiento
                }

            }
            else if (!string.IsNullOrEmpty(Accion))
            {

                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Accion", Accion));
                int resultado = MiCnn.DMLUpdateDeleteInsert("SPGuardarAccionBitacora");
                if (resultado > 0)
                {
                    // si entra aqui significa que se agrego correctamente
                    // aunque claro esto no se deberia decir al usuario esto solo queda para mi prueba de funcionamiento
                }
            }
        }

        public DataTable Listar(string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));
            R = MiCnn.DMLSelect("SPBitacoraListarAll");
            return R;
        }



        public DataTable ListarConFechas(DateTime desde, DateTime hasta, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaDesde", desde));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@FechaHasta", hasta));
            R = MiCnn.DMLSelect("SPBitacoraListarConFechas");
            return R;
        }




    }
}
